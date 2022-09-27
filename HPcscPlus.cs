using EekCharacterEngine;
using EekEvents;
using EekEvents.Stories;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.InputSystem;
using Object = Il2CppSystem.Object;

namespace HPCSC
{
    public class HPcscPlus : MelonMod
    {
        public bool InGameMain = false;

        public StoryData MainStoryData;
        private const int EditorWidth = 800;

        private static readonly string[] Characters = new string[] {
            "Amy",
            "Arin",
            "Ashley",
            "Brittney",
            "Compubrah",
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
        private readonly CharacterStory[] CharacterStoryObjects = new CharacterStory[30];
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
        private readonly string[][] StoryValues = new string[30][] { new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200], new string[200] };

        private readonly CBLCMJKCKKD[] CompareTypesArray = new CBLCMJKCKKD[] {
                CBLCMJKCKKD.Never,
                CBLCMJKCKKD.Clothing,
                CBLCMJKCKKD.CoinFlip,
                CBLCMJKCKKD.CompareValues,
                CBLCMJKCKKD.CriteriaGroup,
                CBLCMJKCKKD.CutScene,
                CBLCMJKCKKD.Dialogue,
                CBLCMJKCKKD.Distance,
                CBLCMJKCKKD.Door,
                CBLCMJKCKKD.IntimacyPartner,
                CBLCMJKCKKD.IntimacyState,
                CBLCMJKCKKD.InVicinity,
                CBLCMJKCKKD.InVicinityAndVision,
                CBLCMJKCKKD.InZone,
                CBLCMJKCKKD.IsBeingSpokenTo,
                CBLCMJKCKKD.IsCharacterEnabled,
                CBLCMJKCKKD.IsCurrentlyBeingUsed,
                CBLCMJKCKKD.IsCurrentlyUsing,
                CBLCMJKCKKD.IsExplicitGameVersion,
                CBLCMJKCKKD.IsInFrontOf,
                CBLCMJKCKKD.IsInHouse,
                CBLCMJKCKKD.IsNewGame,
                CBLCMJKCKKD.IsOnlyInVicinityAndVisionOf,
                CBLCMJKCKKD.IsOnlyInVicinityOf,
                CBLCMJKCKKD.IsOnlyInVisionOf,
                CBLCMJKCKKD.IsZoneEmpty,
                CBLCMJKCKKD.Item,
                CBLCMJKCKKD.ItemFromItemGroup,
                CBLCMJKCKKD.MetByPlayer,
                CBLCMJKCKKD.None,
                CBLCMJKCKKD.Personality,
                CBLCMJKCKKD.PlayerGender,
                CBLCMJKCKKD.PlayerInventory,
                CBLCMJKCKKD.PlayerPrefs,
                CBLCMJKCKKD.Posing,
                CBLCMJKCKKD.Property,
                CBLCMJKCKKD.Quest,
                CBLCMJKCKKD.SameZoneAs,
                CBLCMJKCKKD.Social,
                CBLCMJKCKKD.State,
                CBLCMJKCKKD.UseLegacyIntimacy,
                CBLCMJKCKKD.Value,
                CBLCMJKCKKD.Vision
            };

        //private const int EditorCharacterSelectionHeight = 60;
        private readonly int EditorHeight = Screen.height;
        private readonly int EditorX = Screen.width - EditorWidth;
        private readonly int EditorY = 0;

        private readonly JsonsSupreme Json = new JsonsSupreme();
        private readonly GUILayoutOption[] Opt = new GUILayoutOption[0];
        private readonly bool RemoveVaHints = true;

        private CharacterStoryData _selectedStory;

        private int AlternateTextScrollPosition;
        private string CurrentStoryFolder;
        private int DialogueScrollPosition;

        //default options, cant create others due to il2cpp limitations
        private Rect EditorWindow;

        private GameManager GameManagerInstance;
        private MainStory MainStoryObject;
        private int SelectionIndex = 0;

        //attributes
        private bool ShowEditor = true;

        private List<CharacterStoryData> Stories;
        private bool StoriesSet = false;
        private bool StorySelected = false;

        private MelonPreferences_Category settings;
        private MelonPreferences_Entry<bool> enableCSC;


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

        public int DisplayNumberBlock(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-", bool showNumber = true)
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

        public int DisplayNumberHorizontal(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-", bool showNumber = true)
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

        public int DisplayNumberVertical(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-", bool showNumber = true)
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

        public void LoadAndParseCurrentStory()
        {
            CurrentStoryFolder = StoryData.AOOPOCNMMEO(GameManager.GetActiveStoryName());

            MelonLogger.Msg(System.ConsoleColor.DarkMagenta, $"Current story found in {CurrentStoryFolder}");

            string[] paths = CurrentStoryFolder.Split('/');

            string tempF = $"{CurrentStoryFolder}{paths[paths.Length - 2]}.story";

            MelonLogger.Msg(System.ConsoleColor.DarkMagenta, $"Current story file found at {tempF}, trying to parse...");

            FileStream fileStream = File.Open(tempF, FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            MelonLogger.Msg("Creating Main Story object now...");
            MainStoryObject = ParseJsonToStory(streamReader.ReadToEnd());

            fileStream.Close();
            streamReader.Close();

            if (MainStoryObject != null)
            {
                MelonLogger.Msg(System.ConsoleColor.DarkGreen, "Story parsed successfully.");
            }
            else
            {
                MelonLogger.Msg(System.ConsoleColor.Red, "Parsing failed!");
            }

            int x = 0;

            MelonLogger.Msg("Parsing character stories now.");

            foreach (var file in Directory.GetFiles(CurrentStoryFolder))
            {
                if (Path.GetFileName(file).Split('.').Length == 2)
                {
                    if (Path.GetFileName(file).Split('.')[1] == "character")
                    {
                        MelonLogger.Msg(System.ConsoleColor.DarkGray, $"Found {Path.GetFileName(file).Split('.')[0]}");
                        //use custom json/story parser
                        CharacterStory tempStory = ParseJsonToCharacterStory(File.ReadAllText(file));
                        if (tempStory != null)
                        {
                            CharacterStoryObjects[x++] = tempStory;
                            MelonLogger.Msg(System.ConsoleColor.DarkGreen, $"{Path.GetFileNameWithoutExtension(file)}'s Story parsed successfully.");
                        }
                        else
                        {
                            MelonLogger.Msg(System.ConsoleColor.Red, "Parsing failed!");
                        }
                    }
                }
            }

            for (int i = 0; i < CharacterStoryObjects.Length; i++)
            {
                StoryValues[i] = (CharacterStoryObjects[i].GetStoryValues().ToArray());
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
            Json.FreeHandles();
            settings.SaveToFile();
        }

        //on start
        public override void OnApplicationStart()
        {
            settings = MelonPreferences.CreateCategory("CSC");
            enableCSC = settings.CreateEntry("enableCSC", true);

            EditorWindow = new Rect(EditorX, EditorY, EditorWidth, EditorHeight);

            if (enableCSC.Value)
            {
                MelonLogger.Msg("CSC is enabled, will take some time on game load");
                Json.Initialize();
            }
            else
            {
                MelonLogger.Msg("CSC is currently disabled, left ALT + T to toggle");
            }
        }

        //every time ui is updated
        public override void OnGUI()
        {
            if (InGameMain && ShowEditor && enableCSC.Value)
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
            if(InGameMain)MelonLogger.Msg($"Loading into {sceneName} ({buildIndex})");

            //get references to the GameManager and so on
            if (InGameMain && enableCSC.Value)
            {
                InitializeInGame();
            }
        }

        private void InitializeInGame()
        {
            GameManagerInstance = GameManager.HPMMPJACDIL();

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

        //every frame
        public override void OnUpdate()
        {
            if (enableCSC.Value)
            {
                if (Keyboard.current[Key.LeftAlt].isPressed && Keyboard.current[Key.T].wasPressedThisFrame)
                {
                    DisableCSC();
                }

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
            else
            {
                if (Keyboard.current[Key.LeftAlt].isPressed && Keyboard.current[Key.T].wasPressedThisFrame)
                {
                    EnableCSC();
                }
            }
        }

        private void EnableCSC()
        {
            enableCSC.Value = true;
            MelonLogger.Msg("CSC is now enabled");

            if (!StoriesSet)
            {
                Json.Initialize();

                InitializeInGame();
            }
        }

        private void DisableCSC()
        {
            enableCSC.Value = false;
            MelonLogger.Msg("CSC is now disabled");
        }

        public CharacterStory ParseJsonToCharacterStory(string tempS)
        {
            try
            {
                CharacterStory charStory = Json.SetObjectValuesSlow(JsonsSupreme.SplitJson(tempS), Il2CppType.Of<CharacterStory>()).Cast<CharacterStory>();

                return charStory;
            }
            catch (System.Exception e)
            {
                MelonLogger.Msg(System.ConsoleColor.Red, e.Message + e.StackTrace);
                return null;
            }
        }

        public MainStory ParseJsonToStory(string tempS)
        {
            try
            {
                MainStory mainStory = Json.CreateMainStory(tempS);
                //mainStory.GetAchievements()[0].SetName("asdufgsd");
                return mainStory;
            }
            catch (System.Exception e)
            {
                MelonLogger.Msg(System.ConsoleColor.Red, e.Message + e.StackTrace);
                return null;
            }

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

        private EACMHIPDGEE DisplayBoolValueSelector(EACMHIPDGEE boolValue)
        {
            if (GUILayout.Toggle(boolValue == EACMHIPDGEE.True, boolValue.ToString(), Opt))
            {
                boolValue = EACMHIPDGEE.True;
            }
            else
            {
                boolValue = EACMHIPDGEE.False;
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
            for (int i = 0; i < CharacterStoryObjects.Length; i++)
            {
                if (CharacterStoryObjects[i].GetCharacterName() == characterName)
                {
                    int t = 0;
                    for (int k = 0; k < StoryValues[i].Length; k++)
                    {
                        if (StoryValues[i][k] == key)
                        {
                            t = k;
                            break;
                        }
                    }

                    if (t < 0 || t > StoryValues[i].Length - 1)
                    {
                        t = 0;
                    }

                    key = StoryValues[i][DisplayNumberBlock(t, 0, StoryValues.Length - 1, key, ">", "<", false)];

                    return key;
                }
            }
            return "NONE";
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

        private CBLCMJKCKKD DisplayCompareTypes(CBLCMJKCKKD type)
        {
            GUILayout.BeginVertical(Opt);
            int index = 0;
            foreach (CBLCMJKCKKD item in CompareTypesArray)
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
                case CBLCMJKCKKD.Never:
                    //Nothing?
                    break;

                case CBLCMJKCKKD.Clothing:
                    criterion = DisplayCompareTypeClothing(criterion);
                    break;

                case CBLCMJKCKKD.CoinFlip:
                    //nothing needed, its 50/50 anyways
                    break;

                case CBLCMJKCKKD.CompareValues:
                    criterion = DisplayCompareTypeCompareValues(criterion);
                    break;

                case CBLCMJKCKKD.CriteriaGroup:
                    //criteriagroup(id) as key, true/false as option (0/1)
                    break;

                case CBLCMJKCKKD.CutScene:
                    //no idea what is needed
                    break;

                case CBLCMJKCKKD.Dialogue:
                    //Character as character, dialogie id as value, dialogue status as dialogue status
                    break;

                case CBLCMJKCKKD.Distance:
                    //Object name 1 as key(typed), Object name 2 as key2(typed), equal value as equationvalue, distance as value
                    break;

                case CBLCMJKCKKD.Door:
                    //dor name as key, door option as dooroption
                    break;

                case CBLCMJKCKKD.IntimacyPartner:
                    //character as charater, equals value as equalsvalue, character 2 as value
                    break;

                case CBLCMJKCKKD.IntimacyState:
                    //character as character, equals vlaue as equalsvalue, state as value
                    break;

                case CBLCMJKCKKD.InZone:
                    //character as character, zone name as key, state as boolvalue
                    break;

                case CBLCMJKCKKD.InVicinity:
                    //character as character, character as character2, state as boolvalue
                    break;

                case CBLCMJKCKKD.InVicinityAndVision:
                    //same as invicinity
                    break;

                case CBLCMJKCKKD.Item:
                    //item as key, item comparison as itemcomparison, character as character, state as boolvalue
                    //or it not involved with characters(no "To/By")
                    //item as key, item comparison as itemcomparison, state as boolvalue
                    break;

                case CBLCMJKCKKD.IsOnlyInVicinityOf:
                    //same as invicinity
                    break;

                case CBLCMJKCKKD.IsOnlyInVisionOf:
                    //same as invicinity
                    break;

                case CBLCMJKCKKD.IsOnlyInVicinityAndVisionOf:
                    //same as invicinity
                    break;

                case CBLCMJKCKKD.IsCharacterEnabled:
                    //character as character, value as boolvalue
                    break;

                case CBLCMJKCKKD.IsCurrentlyBeingUsed:
                    //item name as key, value as boolvalue
                    break;

                case CBLCMJKCKKD.IsCurrentlyUsing:
                    //character as character, item as key, state as boolvalue
                    break;

                case CBLCMJKCKKD.IsExplicitGameVersion:
                    //state as boolvalue
                    break;

                case CBLCMJKCKKD.IsInFrontOf:
                    //character as character2, characetr as character, state as boolvalue
                    break;

                case CBLCMJKCKKD.IsInHouse:
                    //character as character, state as boolvalue
                    break;

                case CBLCMJKCKKD.IsNewGame:
                    //state as boolvalue
                    break;

                case CBLCMJKCKKD.IsZoneEmpty:
                    //zone as key, state as boolvalue
                    break;

                case CBLCMJKCKKD.ItemFromItemGroup:
                    //greyed out in csc
                    break;

                case CBLCMJKCKKD.MetByPlayer:
                    //character as character, value as boolvalue
                    break;

                case CBLCMJKCKKD.Personality:
                    //character as character, personality type as key, comparison as equationvalue, value as boolvalue
                    break;

                case CBLCMJKCKKD.IsBeingSpokenTo:
                    //character as character, value as boolvalue
                    break;

                case CBLCMJKCKKD.PlayerGender:
                    //gender as value
                    break;

                case CBLCMJKCKKD.PlayerInventory:
                    //has item: item as key, value as boolvalue
                    //has at least one item: value as boolvalue
                    break;

                case CBLCMJKCKKD.Posing:
                    //is currently posing: character as character, value as boolvalue
                    //current pose: character as character, pose id as value, value as boolvalue
                    break;

                case CBLCMJKCKKD.Property:
                    //character as character, property id as value, value as boolvalue
                    break;

                case CBLCMJKCKKD.Quest:
                    //quest id as key, quest name as key2, value as boolvalue
                    break;

                case CBLCMJKCKKD.SameZoneAs:
                    //character as character, character as character2, value as boolvalue
                    break;

                case CBLCMJKCKKD.Social:
                    //for one: character as character, status as social status, comparison as equationvalue, value as value
                    //for two: character as character, character as character2, status as social status, comparison as equationvalue, value as value
                    break;

                case CBLCMJKCKKD.State:
                    //character as character, state id as value, value as boolvalue
                    break;

                case CBLCMJKCKKD.Value:
                    //character as character, value name as key, comparison as equationvalue, value as value
                    break;

                case CBLCMJKCKKD.Vision:
                    //character as character, character as character2, value as boolvalue
                    break;

                case CBLCMJKCKKD.PlayerPrefs:
                    //value name as key, comparison as equationvalue, value as value
                    break;

                case CBLCMJKCKKD.UseLegacyIntimacy:
                    //state as boolvalue
                    break;

                case CBLCMJKCKKD.None:
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

        private HENLFNFHCMH DisplayValueFormulaSelector(HENLFNFHCMH valueFormula)
        {
            valueFormula = (HENLFNFHCMH)DisplayNumberBlock((int)valueFormula, 0, 3, valueFormula.ToString(), ">", "<", false);
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
    }
}