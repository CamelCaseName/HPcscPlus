using EekCharacterEngine;
using EekEvents;
using EekEvents.Stories;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using MelonLoader;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.InputSystem;
using Object = Il2CppSystem.Object;

namespace Project
{
    public class HPcscPlus : MelonMod
    {
        public bool InGameMain = false;

        private const int EditorWidth = 800;

        private readonly string[] Characters = new string[] {
            "Amy",
            "Arin",
            "Ashley",
            "Brittney",
            "Dan",
            "Derek",
            "Frank",
            "Katherine",
            "Leah",
            "Lety",
            "Madison",
            "Patrick",
            "Player",
            "Rachael",
            "Stephanie",
            "Vickie"
        };
        private readonly CharacterStory[] CharacterStoryObjects = new CharacterStory[17];
        private readonly string[] ClothingPieces = new string[] {
            "Top",
            "Bottom",
            "Underwear",
            "Bra",
            "Shoes",
            "Accessory",
            "StrapOn"
        };
        private readonly string[] ClothingSets = new string[] {
            "Any Set",
            "Set 0",
            "Set 1"
            };

        private readonly CompareTypes[] CompareTypesArray = new CompareTypes[] {
                CompareTypes.Never,
                CompareTypes.Clothing,
                CompareTypes.CoinFlip,
                CompareTypes.CompareValues,
                CompareTypes.CriteriaGroup,
                CompareTypes.CutScene,
                CompareTypes.Dialogue,
                CompareTypes.Distance,
                CompareTypes.Door,
                CompareTypes.IntimacyPartner,
                CompareTypes.IntimacyState,
                CompareTypes.InVicinity,
                CompareTypes.InVicinityAndVision,
                CompareTypes.InZone,
                CompareTypes.IsAloneWithPlayer,
                CompareTypes.IsBeingSpokenTo,
                CompareTypes.IsCharacterEnabled,
                CompareTypes.IsCurrentlyBeingUsed,
                CompareTypes.IsCurrentlyUsing,
                CompareTypes.IsExplicitGameVersion,
                CompareTypes.IsInFrontOf,
                CompareTypes.IsInHouse,
                CompareTypes.IsNewGame,
                CompareTypes.IsOnlyInVicinityAndVisionOf,
                CompareTypes.IsOnlyInVicinityOf,
                CompareTypes.IsOnlyInVisionOf,
                CompareTypes.IsZoneEmpty,
                CompareTypes.Item,
                CompareTypes.ItemFromItemGroup,
                CompareTypes.MetByPlayer,
                CompareTypes.None,
                CompareTypes.Personality,
                CompareTypes.PlayerBeingSpokenTo,
                CompareTypes.PlayerGender,
                CompareTypes.PlayerInventory,
                CompareTypes.PlayerPrefs,
                CompareTypes.Posing,
                CompareTypes.Property,
                CompareTypes.Quest,
                CompareTypes.SameZoneAs,
                CompareTypes.Social,
                CompareTypes.State,
                CompareTypes.UseLegacyIntimacy,
                CompareTypes.Value,
                CompareTypes.Vision
            };

        //private const int EditorCharacterSelectionHeight = 60;
        private readonly int EditorHeight = Screen.height;
        private readonly int EditorX = Screen.width - EditorWidth;
        private readonly int EditorY = 0;

        private readonly GUILayoutOption[] Opt = new GUILayoutOption[0];

        private readonly bool RemoveVaHints = true;

        private CharacterStoryData _selectedStory;

        private int AlternateTextScrollPosition;
        private string CurrentStoryFolder;
        private int DialogueScrollPosition;

        //default options, cant create others due to il2cpp limitations
        private Rect EditorWindow;

        private GameManager GameManagerInstance;

        private StoryData MainStoryData;
        private MainStory MainStoryObject;
        private bool secondLayerCriteriaList = false;
        private int SelectionIndex = 0;

        //attributes
        private bool ShowEditor = false;

        private List<CharacterStoryData> Stories;
        private bool StoriesSet = false;
        private bool StorySelected = false;
        private Type[] StoryTypes;

        public enum JsonLabels
        {
            START_OBJECT,
            END_OBJECT,
            START_LIST,
            END_LIST,
            NULL
        }

        private CharacterStoryData SelectedStory
        {
            get
            {
                return _selectedStory;
            }
            set
            {
                if (value != _selectedStory && value != null)
                {
                    _selectedStory = value;
                    StorySelected = true;
                    //call stuff here
                    MelonLogger.Msg($"Story selected: {value.CharacterName}");
                }
            }
        }
        //methods

        public void LoadAndParseCurrentStory()
        {
            CurrentStoryFolder = StoryData.GetInternalStoryFolder(GameManager.GetActiveStoryName());

            MelonLogger.Msg($"Current story found in {CurrentStoryFolder}");

            string[] paths = CurrentStoryFolder.Split('/');

            string tempF = $"{CurrentStoryFolder}{paths[paths.Length - 2]}.story";
            string tempS = File.ReadAllText(tempF);

            if (tempS.Length > 0)
            {
                MelonLogger.Msg($"Current story file found at {tempF}, trying to parse...");
                MainStoryObject = ParseJsonToStory(tempS);
                //MainStoryObject = JsonConvert.DeserializeObject<MainStory>(tempS);
                if (MainStoryObject != null)
                {
                    MelonLogger.Msg(System.ConsoleColor.DarkGreen, "Story parsed successfully.");
                }
            }
            else
            {
                MelonLogger.Msg(System.ConsoleColor.Red, "Error reading story file!");
            }

            MelonLogger.Msg("Parsing character stories now.");

            int x = 0;

            foreach (var file in Directory.GetFiles(CurrentStoryFolder))
            {
                MelonLogger.Msg(System.ConsoleColor.DarkGray, $"Found {Path.GetFileName(file).Split('.')[0]}");
                if (Path.GetFileName(file).Split('.')[1] == "character")
                {
                    //use custom json/story parser
                    CharacterStory tempStory = ParseJsonToCharacterStory(tempS);
                    if (tempStory != null)
                    {
                        CharacterStoryObjects[x] = tempStory;
                        x++;
                        MelonLogger.Msg(System.ConsoleColor.Gray, $"Parsed {Path.GetFileNameWithoutExtension(file)}'s Story.");
                    }
                }
            }

            MelonLogger.Msg(System.ConsoleColor.Green, "Done parsing :)");
        }

        public void LogMethodInfo(MethodInfo methodInfo)
        {
            MelonLogger.Msg($"{(methodInfo.IsPublic ? "public" : "private")} {methodInfo.ReturnType.Name} {methodInfo.Name} : {methodInfo.GetParametersCount()} parameters");
        }

        //on quit
        public override void OnApplicationQuit()
        {
        }

        //on start
        public override void OnApplicationStart()
        {

            ClassInjector.RegisterTypeInIl2Cpp<Criterion>();
            ClassInjector.RegisterTypeInIl2Cpp<OnTakeActionEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemAction>();
            ClassInjector.RegisterTypeInIl2Cpp<OnSuccessEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<UseWith>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemOverride>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemGroupBehavior>();
            ClassInjector.RegisterTypeInIl2Cpp<Achievement>();
            ClassInjector.RegisterTypeInIl2Cpp<CriteriaList2>();
            ClassInjector.RegisterTypeInIl2Cpp<CriteriaList1>();
            ClassInjector.RegisterTypeInIl2Cpp<CriteriaGroup>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemGroup>();
            ClassInjector.RegisterTypeInIl2Cpp<GameStartEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<Critera>();
            ClassInjector.RegisterTypeInIl2Cpp<Event>();
            ClassInjector.RegisterTypeInIl2Cpp<PlayerReaction>();
            ClassInjector.RegisterTypeInIl2Cpp<MainStory>();
            ClassInjector.RegisterTypeInIl2Cpp<AlternateText>();
            ClassInjector.RegisterTypeInIl2Cpp<CloseEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<ResponseCriteria>();
            ClassInjector.RegisterTypeInIl2Cpp<ResponseEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<Response>();
            ClassInjector.RegisterTypeInIl2Cpp<StartEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<Dialogue>();
            ClassInjector.RegisterTypeInIl2Cpp<GlobalGoodbyeResponse>();
            ClassInjector.RegisterTypeInIl2Cpp<GlobalResponse>();
            ClassInjector.RegisterTypeInIl2Cpp<BackgroundChatter>();
            ClassInjector.RegisterTypeInIl2Cpp<Valuee>();
            ClassInjector.RegisterTypeInIl2Cpp<Personality>();
            ClassInjector.RegisterTypeInIl2Cpp<ExtendedDetail>();
            ClassInjector.RegisterTypeInIl2Cpp<Quest>();
            ClassInjector.RegisterTypeInIl2Cpp<Reaction>();
            ClassInjector.RegisterTypeInIl2Cpp<OnAcceptEvent>();
            ClassInjector.RegisterTypeInIl2Cpp<StoryItem>();
            ClassInjector.RegisterTypeInIl2Cpp<CharacterStory>();

            StoryTypes = new Type[] {
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<OnTakeActionEvent>(),
                Il2CppType.Of<ItemAction>(),
                Il2CppType.Of<OnSuccessEvent>(),
                Il2CppType.Of<UseWith>(),
                Il2CppType.Of<ItemOverride>(),
                Il2CppType.Of<ItemGroupBehavior>(),
                Il2CppType.Of<Achievement>(),
                Il2CppType.Of<CriteriaList2>(),
                Il2CppType.Of<CriteriaList1>(),
                Il2CppType.Of<CriteriaGroup>(),
                Il2CppType.Of<ItemGroup>(),
                Il2CppType.Of<GameStartEvent>(),
                Il2CppType.Of<Critera>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<PlayerReaction>(),
                Il2CppType.Of<MainStory>(),
                Il2CppType.Of<AlternateText>(),
                Il2CppType.Of<CloseEvent>(),
                Il2CppType.Of<ResponseCriteria>(),
                Il2CppType.Of<ResponseEvent>(),
                Il2CppType.Of<Response>(),
                Il2CppType.Of<StartEvent>(),
                Il2CppType.Of<Dialogue>(),
                Il2CppType.Of<GlobalGoodbyeResponse>(),
                Il2CppType.Of<GlobalResponse>(),
                Il2CppType.Of<BackgroundChatter>(),
                Il2CppType.Of<Valuee>(),
                Il2CppType.Of<Personality>(),
                Il2CppType.Of<ExtendedDetail>(),
                Il2CppType.Of<Quest>(),
                Il2CppType.Of<Reaction>(),
                Il2CppType.Of<OnAcceptEvent>(),
                Il2CppType.Of<StoryItem>(),
                Il2CppType.Of<CharacterStory>()
            };

            EditorWindow = new Rect(EditorX, EditorY, EditorWidth, EditorHeight);
        }

        //every time ui is updated
        public override void OnGUI()
        {
            if (InGameMain && ShowEditor)
            {
                //also do keys and mouse by events:
                //Event currentEvent = Event.current;
                //then get event type via the .type

                //create character selection sliders
                //Wrap everything in the designated GUI Area
                GUILayout.BeginArea(EditorWindow, (GUIStyle)"Box");
                //GUILayout.BeginArea(EditorWindow, "cscPlus", "Box");
                GUILayout.BeginVertical(Opt);

                DisplayCharacterStorySelector();

                if (StorySelected)
                {
                    DisplayDialogueParts();
                    //todo show save and then also reload the story
                    //todo export on save so it is really saved
                }

                //end all
                GUILayout.EndVertical();
                GUILayout.EndArea();
            }
        }
        //when the main game scene was loaded
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            InGameMain = sceneName == "GameMain";
            MelonLogger.Msg($"scene {sceneName} loaded ({buildIndex}) igm: {InGameMain}");

            //get references to the GameManager and so on
            if (InGameMain)
            {
                GameManagerInstance = GameManager.GetActiveGameManager();

                Stories = GameManager.GetCharacterStories();

                MainStoryData = GameManager.GetActiveStory();

                LoadAndParseCurrentStory();

                //parse story to custom format from file here, eeks libraries don't provide enough info lol

                StoriesSet = true;

                //add stories to game
                foreach (var story in Stories)
                {
                    GameManagerInstance.RegisterCharacterStory(story);
                }
            }
        }

        //every frame
        public override void OnUpdate()
        {
            if (StoriesSet)
            {
                //check for keypresses to open story editor, toggle window
                if (Keyboard.current[Key.LeftAlt].isPressed && Keyboard.current[Key.U].wasPressedThisFrame)
                {
                    //MelonLogger.Msg($"ui shown {ShowEditor}");
                    ShowEditor = !ShowEditor;
                }
            }
        }

        public CharacterStory ParseJsonToCharacterStory(string tempS)
        {
            throw new System.NotImplementedException();
        }

        public MainStory ParseJsonToStory(string tempS)
        {
            List<string> tokens = SplitJson(tempS);

            MainStory mainStory = SetObjectValues<MainStory>(tokens, Il2CppType.Of<MainStory>(), new Boolean());

            MelonLogger.Msg("returning object");

            return mainStory;
        }

        private string ConstrainLength(string input)
        {
            string output = "";
            bool inWord;
            int maxWordLength = 15;
            int MaxTextLength = 45;
            int currentWordLength = 0;
            int currentLength = 0;

            foreach (char c in input)
            {
                if (c != ' ' && c != '\n' && c != '\r')
                {
                    inWord = true;
                    currentWordLength++;
                }
                else
                {
                    inWord = false;
                    currentWordLength = 0;
                }

                currentLength++;

                //if line is short still
                if (currentLength <= MaxTextLength)
                {
                    output += c;
                }
                else
                {
                    if (inWord && currentWordLength < maxWordLength)
                    {
                        //line is too long but we in a word
                        output += c;
                    }
                    else
                    {
                        output += c + "\n";
                        currentLength = 0;
                    }
                }
            }

            return output;
        }

        private void DisplayAlternateTexts(EekEvents.Dialogues.Dialogue dialogue)
        {
            GUILayout.BeginVertical("Box", Opt);

            if (dialogue.AlternateTexts.Count > 1)
            {
                GUILayout.Box("---Alternate Texts---", Opt);
                //add slider to select currently displayed alternate text
                AlternateTextScrollPosition = (int)GUILayout.HorizontalSlider(AlternateTextScrollPosition, 0, dialogue.AlternateTexts.Count - 1, Opt);
            }
            else
            {
                GUILayout.Box("---Alternate Text---", Opt);
            }
            if (dialogue.AlternateTexts.Count > 0)
            {
                GUILayout.BeginHorizontal(Opt);
                if (GUILayout.Button("Add Alternate Text", Opt))
                {
                    dialogue.AlternateTexts.Add(new EekEvents.Dialogues.AlternateDialogueText());
                    AlternateTextScrollPosition++;
                }
                if (GUILayout.Button("Remove Current Alternate Text", Opt) && dialogue.AlternateTexts.Count > 0)
                {
                    dialogue.AlternateTexts.RemoveAt(AlternateTextScrollPosition);
                    AlternateTextScrollPosition--;
                }
                GUILayout.EndHorizontal();

                string altText = dialogue.AlternateTexts[AlternateTextScrollPosition].Text;
                if (RemoveVaHints) altText = RemoveVAHints(altText);
                altText = ConstrainLength(altText);

                //the actual text
                GUILayout.Label(altText, "Box", Opt);

                //order of the dialogue
                dialogue.AlternateTexts[AlternateTextScrollPosition].Order = DisplayNumberHorizontal(dialogue.AlternateTexts[AlternateTextScrollPosition].Order, 0, int.MaxValue, "Sort Order");
                dialogue.AlternateTexts[AlternateTextScrollPosition].Critera = DisplayCriteria(dialogue.AlternateTexts[AlternateTextScrollPosition].Critera);
            }
            else
            {
                if (GUILayout.Button("Add Alternate Text", Opt))
                {
                    dialogue.AlternateTexts.Add(new EekEvents.Dialogues.AlternateDialogueText());
                }
            }

            //end portion for the alternate texts
            GUILayout.EndVertical();
        }

        private BoolCritera DisplayBoolValueSelector(BoolCritera boolValue)
        {
            if (GUILayout.Toggle(boolValue == BoolCritera.True, boolValue.ToString(), Opt))
            {
                boolValue = BoolCritera.True;
            }
            else
            {
                boolValue = BoolCritera.False;
            }
            return boolValue;
        }

        private string DisplayCharacterSelector(string character, string textBefore)
        {
            GUILayout.BeginVertical(Opt);
            int index = 0;
            bool found = false;
            foreach (string item in Characters)
            {
                if (item == character)
                {
                    found = true;
                    break;
                }
                index++;
            }
            //fallback
            if (!found) index = 0;

            //display compare type and selection
            index = DisplayNumberBlock(index, 0, Characters.Length - 1, $"{textBefore}{Characters[index]}", ">", "<", false);

            character = Characters[index];

            GUILayout.EndVertical();

            return character;
        }

        private void DisplayCharacterStorySelector()
        {
            //title lol
            GUILayout.BeginHorizontal(Opt);
            GUILayout.Box("cscPlus by Lenny", Opt);
            GUILayout.EndHorizontal();

            //Begin the group catpuring both buttons and slider
            GUILayout.BeginHorizontal(Opt);

            //button to select character
            if (GUILayout.Button("Select the character\nto edit the story of", Opt))
            {
                SelectedStory = Stories[SelectionIndex];
            }

            //Arrange two more Controls vertically beside the Button
            GUILayout.BeginVertical(Opt);
            GUILayout.Box($"Character: {Stories[SelectionIndex].CharacterName}", Opt);
            SelectionIndex = (int)GUILayout.HorizontalSlider(SelectionIndex, 0.0f, Stories.Count - 1, Opt);

            //End the Groups and Area
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }

        private string DisplayCharacterValueSelector(string key, string characterName)
        {
            //EekEvents.Values.ValueStore.InitializeValues(characterName);

            var temp = EekEvents.Values.ValueStore.GetValues(characterName).GetCurrentValuesAsStringList();

            //has fewer values than the method above???
            //var temp = EekEvents.Values.ValueStore.GetValues(characterName)._dirtyValues;
            //var temp = EekEvents.Values.ValueStore.GetValues(characterName)._items;
            //SaveLoadManager.PerformAutoSave();
            //var temp = SaveLoadManager.autoSave.NPCs[0].Values.ToArray();

            if (temp.Count <= 0)
            {
                MelonLogger.Msg("no values found");
            }
            else
            {
                List<string> StoryValues = new List<string>();

                foreach (var kvp in temp)
                {
                    string cleaner = kvp.Key;
                    if (!cleaner.Contains(":")) StoryValues.Add(cleaner);
                }

                //about half of the values are in this list, the others can't be added via console, they only show up in the csc
                for (int i = 0; i < CharacterStoryObjects.Length; i++)
                {
                    if (CharacterStoryObjects[i] != null)
                    {
                        /*
                        Object story = CharacterStoryObjects[i];

                        MelonLogger.Msg("trying to access the Object methods to return the field with methodinfo via reflection");

                        MelonLogger.Msg("getting type");
                        Type type = Il2CppType.Of<CharacterStory>();

                        MelonLogger.Msg("getting methodinfo");
                        foreach (MethodInfo method in type.GetMethods())
                        {
                            MelonLogger.Msg(method.Name);
                        }
                        MethodInfo GetCharacterNameMethod = type.GetMethod("GetCharacterName");

                        MelonLogger.Msg("invoking Method");
                        Object ret = GetCharacterNameMethod.Invoke(story, null);

                        MelonLogger.Msg("accessing returned object");
                        MelonLogger.Msg($"size of ret: {Marshal.SizeOf(ret)}");
                        MelonLogger.Msg($"hascode of ret: {ret.GetHashCode()} of name: {characterName.GetHashCode()}");
                        if (ret.GetHashCode() == characterName.GetHashCode())
                        {
                            MelonLogger.Msg($"{characterName} story found form parsed");
                            foreach(string value in story.GetStoryValues())
                            {
                                if (!StoryValues.Contains(value))
                                {
                                    StoryValues.Add(value);
                                }
                            }
                        }
                        */
                        MelonLogger.Msg($"trying to access the Object methods{CharacterStoryObjects[i].GetCharacterName()}");
                        MelonLogger.Msg($"trying to access the Object methods{CharacterStoryObjects[i].GetDialogueID()}");
                        MelonLogger.Msg($"trying to access the Object methods{CharacterStoryObjects[i].GetHousePartyVersion()}");
                        MelonLogger.Msg($"trying to access the Object methods{CharacterStoryObjects[i].GetCurrentAspect()}");
                        MelonLogger.Msg($"trying to access the Object methods{CharacterStoryObjects[i].GetDialogues()[0].GetText()}");
                        if (CharacterStoryObjects[i].GetCharacterName() == characterName)
                        {
                            MelonLogger.Msg("Could access method, name is correct");
                        }
                    }
                }

                StoryValues.Sort();
                MelonLogger.Msg("Values here:");

                foreach (var item in StoryValues)
                {
                    MelonLogger.Msg(item);
                }

                int t = StoryValues.IndexOf(key);

                if (t < 0 || t > temp.Count - 1)
                {
                    t = 0;
                }

                key = StoryValues[DisplayNumberBlock(t, 0, StoryValues.Count - 1, key, ">", "<", false)];
            }
            return key;
        }

        private string DisplayClothingSelector(string clothing)
        {
            if (!int.TryParse(clothing, out int clothing_i)) clothing_i = 0;
            clothing_i = DisplayNumberBlock(clothing_i, 0, ClothingPieces.Length - 1, ClothingPieces[clothing_i], ">", "<");
            return clothing_i.ToString();
        }

        private int DisplayClothingSetSelector(int option)
        {
            option = DisplayNumberBlock(option, 0, ClothingSets.Length - 1, ClothingSets[option], ">", "<", false);
            return option;
        }

        private Criteria DisplayCompareTypeClothing(Criteria criterion)
        {
            //character as character for condition, clothing as value, clothing set as option (none 0, number afterwards), boolvalue as value
            criterion.Character = DisplayCharacterSelector(criterion.Character, "");
            //try parsing, if it fails fall back to 0
            criterion.Value = DisplayClothingSelector(criterion.Value);
            criterion.Option = DisplayClothingSetSelector(criterion.Option);
            criterion.BoolValue = DisplayBoolValueSelector(criterion.BoolValue);
            return criterion;
        }

        private Criteria DisplayCompareTypeCompareValues(Criteria criterion)
        {
            //character as character, character as character2, comparison as valueformula, value1 as key, value2 as key2
            criterion.Character = DisplayCharacterSelector(criterion.Character, "");
            criterion.Key = DisplayCharacterValueSelector(criterion.Key, criterion.Character);
            criterion.ValueFormula = DisplayValueFormulaSelector(criterion.ValueFormula);
            criterion.Character2 = DisplayCharacterSelector(criterion.Character2, "");
            criterion.Key2 = DisplayCharacterValueSelector(criterion.Key2, criterion.Character2);
            return criterion;
        }

        private CompareTypes DisplayCompareTypes(CompareTypes type)
        {
            GUILayout.BeginVertical(Opt);
            int index = 0;
            foreach (CompareTypes item in CompareTypesArray)
            {
                if (item == type)
                {
                    break;
                }
                index++;
            }

            //display compare type and selection
            index = DisplayNumberBlock(index, 0, CompareTypesArray.Length - 1, CompareTypesArray[index].ToString(), ">", "<", false);

            type = CompareTypesArray[index];

            GUILayout.EndVertical();

            return type;
        }

        private Criteria DisplayComparisonFields(Criteria criterion)
        {
            //we are already in a horizontal area!
            switch (criterion.CompareType)
            {
                case CompareTypes.Never:
                    //Nothing?
                    break;

                case CompareTypes.Clothing:
                    criterion = DisplayCompareTypeClothing(criterion);
                    break;

                case CompareTypes.CoinFlip:
                    //nothing needed, its 50/50 anyways
                    break;

                case CompareTypes.CompareValues:
                    criterion = DisplayCompareTypeCompareValues(criterion);
                    break;

                case CompareTypes.CriteriaGroup:
                    //criteriagroup(id) as key, true/false as option (0/1)
                    break;

                case CompareTypes.CutScene:
                    //no idea what is needed
                    break;

                case CompareTypes.Dialogue:
                    //Character as character, dialogie id as value, dialogue status as dialogue status
                    break;

                case CompareTypes.Distance:
                    //Object name 1 as key(typed), Object name 2 as key2(typed), equal value as equationvalue, distance as value
                    break;

                case CompareTypes.Door:
                    //dor name as key, door option as dooroption
                    break;

                case CompareTypes.IntimacyPartner:
                    //character as charater, equals value as equalsvalue, character 2 as value
                    break;

                case CompareTypes.IntimacyState:
                    //character as character, equals vlaue as equalsvalue, state as value
                    break;

                case CompareTypes.InZone:
                    //character as character, zone name as key, state as boolvalue
                    break;

                case CompareTypes.InVicinity:
                    //character as character, character as character2, state as boolvalue
                    break;

                case CompareTypes.InVicinityAndVision:
                    //same as invicinity
                    break;

                case CompareTypes.Item:
                    //item as key, item comparison as itemcomparison, character as character, state as boolvalue
                    //or it not involved with characters(no "To/By")
                    //item as key, item comparison as itemcomparison, state as boolvalue
                    break;

                case CompareTypes.IsOnlyInVicinityOf:
                    //same as invicinity
                    break;

                case CompareTypes.IsOnlyInVisionOf:
                    //same as invicinity
                    break;

                case CompareTypes.IsOnlyInVicinityAndVisionOf:
                    //same as invicinity
                    break;

                case CompareTypes.IsAloneWithPlayer:
                    //character as character, value as boolvalue
                    break;

                case CompareTypes.IsCharacterEnabled:
                    //character as character, value as boolvalue
                    break;

                case CompareTypes.IsCurrentlyBeingUsed:
                    //item name as key, value as boolvalue
                    break;

                case CompareTypes.IsCurrentlyUsing:
                    //character as character, item as key, state as boolvalue
                    break;

                case CompareTypes.IsExplicitGameVersion:
                    //state as boolvalue
                    break;

                case CompareTypes.IsInFrontOf:
                    //character as character2, characetr as character, state as boolvalue
                    break;

                case CompareTypes.IsInHouse:
                    //character as character, state as boolvalue
                    break;

                case CompareTypes.IsNewGame:
                    //state as boolvalue
                    break;

                case CompareTypes.IsZoneEmpty:
                    //zone as key, state as boolvalue
                    break;

                case CompareTypes.ItemFromItemGroup:
                    //greyed out in csc
                    break;

                case CompareTypes.MetByPlayer:
                    //character as character, value as boolvalue
                    break;

                case CompareTypes.Personality:
                    //character as character, personality type as key, comparison as equationvalue, value as boolvalue
                    break;

                case CompareTypes.IsBeingSpokenTo:
                    //character as character, value as boolvalue
                    break;

                case CompareTypes.PlayerBeingSpokenTo:
                    //value as boolvalue
                    break;

                case CompareTypes.PlayerGender:
                    //gender as value
                    break;

                case CompareTypes.PlayerInventory:
                    //has item: item as key, value as boolvalue
                    //has at least one item: value as boolvalue
                    break;

                case CompareTypes.Posing:
                    //is currently posing: character as character, value as boolvalue
                    //current pose: character as character, pose id as value, value as boolvalue
                    break;

                case CompareTypes.Property:
                    //character as character, property id as value, value as boolvalue
                    break;

                case CompareTypes.Quest:
                    //quest id as key, quest name as key2, value as boolvalue
                    break;

                case CompareTypes.SameZoneAs:
                    //character as character, character as character2, value as boolvalue
                    break;

                case CompareTypes.Social:
                    //for one: character as character, status as social status, comparison as equationvalue, value as value
                    //for two: character as character, character as character2, status as social status, comparison as equationvalue, value as value
                    break;

                case CompareTypes.State:
                    //character as character, state id as value, value as boolvalue
                    break;

                case CompareTypes.Value:
                    //character as character, value name as key, comparison as equationvalue, value as value
                    break;

                case CompareTypes.Vision:
                    //character as character, character as character2, value as boolvalue
                    break;

                case CompareTypes.PlayerPrefs:
                    //value name as key, comparison as equationvalue, value as value
                    break;

                case CompareTypes.UseLegacyIntimacy:
                    //state as boolvalue
                    break;

                case CompareTypes.None:
                    //none, duh :)
                    break;

                default:
                    break;
            }

            return criterion;
        }

        private List<Criteria> DisplayCriteria(List<Criteria> criteria)
        {
            GUILayout.BeginHorizontal(Opt);
            GUILayout.Space(30f);

            GUILayout.BeginVertical(Opt);
            Criteria CriterionToDelete = null;
            Criteria CriterionToCopy = null;
            Criteria CriterionToMove = null;
            int MoveCriterionDirection = 0; // 1 is up, 2 is down, 0 nothing

            if (criteria.Count > 0)
            {
                foreach (Criteria criterion in criteria)
                {
                    GUILayout.BeginHorizontal("box", Opt);

                    GUILayout.BeginVertical(Opt);
                    if (GUILayout.Button("/\\", Opt) && MoveCriterionDirection == 0)
                    {
                        MoveCriterionDirection = 1;
                        CriterionToMove = criterion;
                    }
                    if (GUILayout.Button("\\/", Opt) && MoveCriterionDirection == 0)
                    {
                        MoveCriterionDirection = 2;
                        CriterionToMove = criterion;
                    }
                    GUILayout.EndVertical();

                    //other fields, refer to the real csc for input/layout
                    criterion.Order = DisplayNumberBlock(criterion.Order, text: "Order");
                    criterion.CompareType = DisplayCompareTypes(criterion.CompareType);

                    Criteria tempCriterion = DisplayComparisonFields(criterion);

                    //copy all fields, cant just copy the Object or even use ref because we are in a for loop
                    criterion.BoolValue = tempCriterion.BoolValue;
                    criterion.Character = tempCriterion.Character;
                    criterion.Character2 = tempCriterion.Character2;
                    criterion.DialogueStatus = tempCriterion.DialogueStatus;
                    criterion.DisplayInEditor = tempCriterion.DisplayInEditor;
                    criterion.DoorOptions = tempCriterion.DoorOptions;
                    criterion.EqualsValue = tempCriterion.EqualsValue;
                    criterion.EquationValue = tempCriterion.EquationValue;
                    criterion.ItemComparison = tempCriterion.ItemComparison;
                    criterion.ItemFromItemGroupComparison = tempCriterion.ItemFromItemGroupComparison;
                    criterion.Key = tempCriterion.Key;
                    criterion.Key2 = tempCriterion.Key2;
                    criterion.Option = tempCriterion.Option;
                    criterion.PlayerInventoryOption = tempCriterion.PlayerInventoryOption;
                    criterion.PoseOption = tempCriterion.PoseOption;
                    criterion.SocialStatus = tempCriterion.SocialStatus;
                    criterion.Value = tempCriterion.Value;
                    criterion.ValueFormula = tempCriterion.ValueFormula;

                    //filler
                    GUILayout.FlexibleSpace();
                    GUILayout.EndHorizontal();

                    //copy and remove buttons below criteria
                    GUILayout.BeginHorizontal(Opt);
                    if (GUILayout.Button("Duplicate", Opt))
                    {
                        CriterionToCopy = criterion;
                    }
                    if (GUILayout.Button("Remove", Opt))
                    {
                        CriterionToDelete = criterion;
                    }
                    GUILayout.EndHorizontal();
                }

                if (CriterionToCopy != null) criteria.Add(DuplicateCriterion(CriterionToCopy));
                if (CriterionToDelete != null) criteria.Remove(CriterionToDelete);
                if (CriterionToMove != null && MoveCriterionDirection != 0)
                {
                    int index = criteria.IndexOf(CriterionToMove);
                    //  move up
                    if (MoveCriterionDirection == 1 && index > 0)
                    {
                        criteria.Remove(CriterionToMove);
                        criteria.Insert(index - 1, CriterionToMove);
                    }
                    //move down
                    else if (MoveCriterionDirection == 2 && index < criteria.Count - 1)
                    {
                        criteria.Remove(CriterionToMove);
                        criteria.Insert(index + 1, CriterionToMove);
                    }
                }
            }

            //add/remove all buttons
            GUILayout.BeginHorizontal("Box", Opt);
            if (GUILayout.Button("Add Criteria Top", Opt))
            {
                criteria.Insert(0, new Criteria());
            }
            if (GUILayout.Button("Add Criteria Bottom", Opt))
            {
                criteria.Add(new Criteria());
            }
            if (GUILayout.Button("Remove All Criteria", Opt))
            {
                criteria.Clear();
            }

            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();

            return criteria;
        }

        private void DisplayDialogueParts()
        {
            GUILayout.BeginHorizontal("Box", Opt);
            //add slider to select current dialogue
            DialogueScrollPosition = (int)GUILayout.VerticalSlider(DialogueScrollPosition, 0, SelectedStory.Dialogues.Count - 1, Opt);

            //gui components with all the things you need
            EekEvents.Dialogues.Dialogue dialogue = SelectedStory.Dialogues[DialogueScrollPosition];

            string text = dialogue.Text;
            if (RemoveVaHints) text = RemoveVAHints(text);
            text = ConstrainLength(text);
            GUILayout.BeginVertical(Opt);

            //id of the dialogue
            GUILayout.Box($"ID: {dialogue.ID}", "box", Opt);

            //the actual text
            GUILayout.Label(text, "Box", Opt);

            //TODO add custom built text fiels where you can actually edit the text
            //get layout rect with guilayoututility.getrect()
            //https://github.com/Unity-Technologies/UnityCsReference/blob/master/Modules/IMGUI/GUILayout.cs

            //other infos, layout is the same as in the csc
            dialogue.SpeakingToCharacterName = DisplayCharacterSelector(dialogue.SpeakingToCharacterName, "Speaking To ");
            dialogue.DoesNotCountAsMet = GUILayout.Toggle(dialogue.DoesNotCountAsMet, "Does not count as \"Met\"", Opt);
            dialogue.ShowGlobalResponses = GUILayout.Toggle(dialogue.ShowGlobalResponses, "Show Global Responses", Opt);
            dialogue.ShowGlobalGoodByeResponses = GUILayout.Toggle(dialogue.ShowGlobalGoodByeResponses, "Use GoodBye Responses", Opt);

            //alternate texts
            DisplayAlternateTexts(dialogue);

            //todo the rest like events, responses and so on
            //todo add toggle/list what to edit from the dialogue, same with all the other things you can edit

            GUILayout.EndVertical();
            //end scrolling portion for the story components
            GUILayout.EndHorizontal();
        }

        private int DisplayNumberBlock(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-", bool showNumber = true)
        {
            GUILayout.BeginVertical("Box", Opt);

            if (text.Length > 0 && !showNumber) GUILayout.Label(text, Opt);
            else if (text.Length > 0) GUILayout.Label($"{text}: {number}", Opt);
            else GUILayout.Label($"{number}", Opt);

            GUILayout.BeginHorizontal(Opt);

            if (GUILayout.Button(minusButton, Opt) && number > min)
            {
                number--;
            }
            if (GUILayout.Button(plusButton, Opt) && number < max)
            {
                number++;
            }

            if (text.Length + number.ToString().Length > 10) GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();

            return number;
        }

        private int DisplayNumberHorizontal(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-", bool showNumber = true)
        {
            GUILayout.BeginHorizontal("Box", Opt);

            if (GUILayout.Button(minusButton, Opt) && number > min)
            {
                number--;
            }
            if (GUILayout.Button(plusButton, Opt) && number < max)
            {
                number++;
            }

            if (text.Length > 0 && !showNumber) GUILayout.Label(text, Opt);
            else if (text.Length > 0) GUILayout.Label($"{text}: {number}", Opt);
            else GUILayout.Label($"{number}", Opt);

            GUILayout.EndHorizontal();

            return number;
        }

        private int DisplayNumberVertical(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-", bool showNumber = true)
        {
            GUILayout.BeginVertical("Box", Opt);

            if (text.Length > 0 && !showNumber) GUILayout.Label(text, Opt);
            else if (text.Length > 0) GUILayout.Label($"{text}: {number}", Opt);
            else GUILayout.Label($"{number}", Opt);

            if (GUILayout.Button(plusButton, Opt) && number < max)
            {
                number++;
            }
            if (GUILayout.Button(minusButton, Opt) && number > min)
            {
                number--;
            }

            GUILayout.EndVertical();

            return number;
        }

        private ValueSpecificFormulas DisplayValueFormulaSelector(ValueSpecificFormulas valueFormula)
        {
            valueFormula = (ValueSpecificFormulas)DisplayNumberBlock((int)valueFormula, 0, 3, valueFormula.ToString(), ">", "<", false);
            return valueFormula;
        }

        private Criteria DuplicateCriterion(Criteria criterion)
        {
            Criteria tempCriterion = new Criteria
            {
                BoolValue = criterion.BoolValue,
                Character = criterion.Character,
                Character2 = criterion.Character2,
                CompareType = criterion.CompareType,
                DialogueStatus = criterion.DialogueStatus,
                DisplayInEditor = criterion.DisplayInEditor,
                DoorOptions = criterion.DoorOptions,
                EqualsValue = criterion.EqualsValue,
                EquationValue = criterion.EquationValue,
                ItemComparison = criterion.ItemComparison,
                ItemFromItemGroupComparison = criterion.ItemFromItemGroupComparison,
                Key = criterion.Key,
                Key2 = criterion.Key2,
                Option = criterion.Option,
                Order = criterion.Order,
                PlayerInventoryOption = criterion.PlayerInventoryOption,
                PoseOption = criterion.PoseOption,
                SocialStatus = criterion.SocialStatus,
                Value = criterion.Value,
                ValueFormula = criterion.ValueFormula
            };

            return tempCriterion;
        }

        private Type FindTypeName(string typeToSearch)
        {
            //MelonLogger.Msg($"TYPE SEARCH: {typeToSearch}");
            if (typeToSearch == "Criteria")
            {
                typeToSearch = "Criterion";
            }
            else if (typeToSearch == "CriteriaList")
            {
                if (secondLayerCriteriaList)
                {
                    typeToSearch = "CriteriaList2";
                }
                else
                {
                    typeToSearch = "CriteriaList1";
                }
            }
            else
            {
                typeToSearch = typeToSearch.Remove(typeToSearch.Length - 1, 1);
            }
            //MelonLogger.Msg($"TYPE SEARCH: adjusted name: {typeToSearch}");
            Type ret = new Type();

            foreach (Type t in StoryTypes)
            {
                if (t.Name == typeToSearch)
                {
                    ret = t;
                    break;
                }
            }
            //MelonLogger.Msg($"TYPE SEARCH: Type found: {ret.Name}");

            return ret;
        }

        private string RemoveVAHints(string input)
        {
            bool inVAHint = false;
            string output = "";
            foreach (char character in input)
            {
                if (character == '[' && !inVAHint)
                {
                    inVAHint = true;
                }
                else if (character == ']' && inVAHint)
                {
                    inVAHint = false;
                }
                else if (!inVAHint)
                {
                    output += character;
                }
            }

            return output;
        }

        private T SetObjectValues<T>(List<string> tokens, Type type, Boolean isSecondLayerCriteriaList) where T : Object, new()
        {
            //iterate through tokens until we reach a start of an object, in the first case the mainstory
            bool startNotFound = true;
            while (startNotFound)
            {
                //MelonLogger.Msg(System.ConsoleColor.DarkGray, $"TOKEN0: {tokens[0]}");
                //go to first start or remove token
                if (tokens[0] == JsonLabels.START_OBJECT.ToString())
                {
                    startNotFound = false;
                    tokens.RemoveAt(0);
                }
                else
                {
                    tokens.RemoveAt(0);
                }
            }

            Object retObject = Activator.CreateInstance(type);
            MelonLogger.Msg(System.ConsoleColor.DarkGray, $"Created object of type {type.Name}");

            //if we can create a new T, get all methods, then calling all set methods using reflection, filling them up with the objects we need
            var methodInfos = type.GetMethods();

            //go through tokens to call the method we need, weith the token after as argument.
            string lastToken = "";
            while (true)
            {
                string token = tokens[0];
                //MelonLogger.Msg(System.ConsoleColor.DarkGray, $"TOKEN1: {token}");

                //list starts
                if (token == JsonLabels.START_LIST.ToString())
                {
                    //create list, then go back to creating objects, then at end we stop and move on in the og object the list is part of
                    //get type of the list elements, name of them in lastToken

                    //get type from method signature !!
                    MethodInfo getList = new MethodInfo();
                    MethodInfo setList = new MethodInfo();

                    foreach (MethodInfo methodInfo in methodInfos)
                    {
                        if (methodInfo.Name == $"Get{lastToken}")
                        {
                            getList = methodInfo;
                        }
                        else if (methodInfo.Name == $"Set{lastToken}")
                        {
                            setList = methodInfo;
                        }
                    }

                    //get new tokens
                    tokens.RemoveAt(0);
                    token = tokens[0];

                    Type listType = getList.ReturnType;
                    Object list = Activator.CreateInstance(listType);
                    MethodInfo listAdd = listType.GetMethod("Add");

                    //as long as we did not reach the end of the list, end it
                    while (tokens[0] != JsonLabels.END_LIST.ToString())
                    {
                        //MelonLogger.Msg(System.ConsoleColor.DarkGray, $"TOKEN2: {token}");
                        Boolean secondLayerStarted = new Boolean();
                        if (!isSecondLayerCriteriaList.m_value && lastToken == "CriteriaList")
                        {
                            secondLayerStarted.m_value = true;
                            isSecondLayerCriteriaList.m_value = true;
                        }
                        Object objectToAdd = SetObjectValues<Object>(tokens, FindTypeName(lastToken), secondLayerStarted);
                        listAdd.Invoke(list, CreateReferenceArray(objectToAdd));
                        isSecondLayerCriteriaList.m_value = false;
                    }
                    //add list
                    //MelonLogger.Msg("adding list");
                    setList.Invoke(retObject, CreateReferenceArray(list));
                }
                else if (token == JsonLabels.END_OBJECT.ToString())
                {
                    tokens.RemoveAt(0);

                    return (T)retObject;
                }
                //else field starts
                else
                {
                    if (tokens[1] != JsonLabels.START_LIST.ToString() && tokens[1] != JsonLabels.START_OBJECT.ToString())
                    {
                        foreach (MethodInfo methodInfo in methodInfos)
                        {
                            if (methodInfo.Name == $"Set{token}")
                            {
                                lastToken = token;
                                tokens.RemoveAt(0);
                                token = tokens[0];
                                //MelonLogger.Msg(System.ConsoleColor.DarkGray, $"TOKEN3: {token}");

                                //get method parameter type so we can cast the string to the correct object
                                Type pType = methodInfo.GetParameterTypes()[0];

                                //try parsing if necessary, defaults to new constructor like values
                                Object tokenObject = TryParseAll(pType, token);

                                methodInfo.Invoke(retObject, CreateReferenceArray(tokenObject));
                                MelonLogger.Msg(System.ConsoleColor.Green, $"Invoke successful! ({methodInfo.Name} with {token} as the parameter)");
                                break;
                            }
                        }
                    }
                }
                lastToken = token;
                tokens.RemoveAt(0);
            }
        }

        private static Il2CppReferenceArray<Object> CreateReferenceArray(Object tokenObject)
        {
            return new Il2CppReferenceArray<Object>(new Object[] { tokenObject });
        }

        private List<string> SplitJson(string tempS)
        {
            List<string> tokens = new List<string>();

            bool inValueString = false;
            string builderString = "";
            List<char> seperators = new List<char>();
            foreach (char charry in "{}[],:")
            {
                seperators.Add(charry);
            }
            List<char> numbers = new List<char>();
            foreach (char numbah in "0123456789.nullfasetr")
            {
                numbers.Add(numbah);
            }

            foreach (char c in tempS)
            {
                //entering string
                if (!inValueString && c == '"')
                {
                    inValueString = true;
                }
                else if (inValueString && c == '"')
                {
                    inValueString = false;
                }
                else if (inValueString)
                {
                    //add char to builder regardless of what it is
                    builderString += c;
                }
                else if (seperators.Contains(c) && !inValueString)
                {
                    //if we hit a seperator, add nonempty strings and clear string builder
                    if (builderString.Length > 0) tokens.Add(builderString);
                    if (c == '[') tokens.Add(JsonLabels.START_LIST.ToString());
                    if (c == ']') tokens.Add(JsonLabels.END_LIST.ToString());
                    if (c == '{') tokens.Add(JsonLabels.START_OBJECT.ToString());
                    if (c == '}') tokens.Add(JsonLabels.END_OBJECT.ToString());
                    builderString = "";
                }
                else
                {
                    if (numbers.Contains(c))
                    {
                        //add char, in names and stuff
                        builderString += c;
                    }
                }
            }

            return tokens;
        }

        private Object TryParseAll(Type type, string token)
        {
            try
            {
                //MelonLogger.Msg($"Type to convert to: {type.FullName}, token: {token}");
                //try casting the types, revert to default if failed
                switch (type.FullName)
                {
                    case "System.Boolean":
                        return new Boolean { m_value = bool.Parse(token) }.BoxIl2CppObject();
                    //case "System.Double":
                    //return new String { m_value = double.Parse(token, System.Globalization.NumberStyles.Float) }.BoxIl2CppObject();
                    case "System.Int32":
                        return new Int32 { m_value = int.Parse(token, System.Globalization.NumberStyles.Integer) }.BoxIl2CppObject();
                    case "System.String":
                        return token;

                    //default null for all other kind of objects
                    default:
                        return null;
                }
            }
            catch
            {
                MelonLogger.Msg(System.ConsoleColor.DarkRed, $"Something went wrong while parsing to {type.FullName}, token: {token}");
                //return default if failed
                return default;
            }
        }
    }
}