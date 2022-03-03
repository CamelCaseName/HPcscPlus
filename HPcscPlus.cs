using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using EekAddOns;
using Il2CppSystem;
using UnhollowerRuntimeLib;
using EekCharacterEngine.Interaction;

namespace Project
{
    public class HPcscPlus : MelonMod
    {
        //attributes
        private bool ShowEditor = false;
        private bool StoriesSet = false;
        private bool StorySelected = false;
        private const int EditorCharacterSelectionHeight = 60;
        private const int EditorHeight = 1000;
        private const int EditorWidth = 600;
        private EekCharacterEngine.GameManager GameManager;
        private EekEvents.Stories.CharacterStoryData _selectedStory;
        private Il2CppSystem.Collections.Generic.List<EekEvents.Stories.CharacterStoryData> Stories;
        private int DialogueScrollPosition;
        private int AlternateTextScrollPosition;
        private int SelectionIndex = 0;
        private readonly bool RemoveVaHints = true;
        private readonly int EditorX = Screen.width - EditorWidth;
        private readonly int EditorY = 0;
        private readonly GUILayoutOption[] Opt = new GUILayoutOption[0]; //default options, cant create others due to il2cpp limitations
        private Rect EditorWindow;
        public bool InGameMain = false;
        private readonly EekEvents.CompareTypes[] CompareTypesArray = new EekEvents.CompareTypes[] {
                EekEvents.CompareTypes.Clothing,
                EekEvents.CompareTypes.CoinFlip,
                EekEvents.CompareTypes.CompareValues,
                EekEvents.CompareTypes.CriteriaGroup,
                EekEvents.CompareTypes.CutScene,
                EekEvents.CompareTypes.Dialogue,
                EekEvents.CompareTypes.Distance,
                EekEvents.CompareTypes.Door,
                EekEvents.CompareTypes.IntimacyPartner,
                EekEvents.CompareTypes.IntimacyState,
                EekEvents.CompareTypes.InVicinity,
                EekEvents.CompareTypes.InVicinityAndVision,
                EekEvents.CompareTypes.InZone,
                EekEvents.CompareTypes.IsAloneWithPlayer,
                EekEvents.CompareTypes.IsBeingSpokenTo,
                EekEvents.CompareTypes.IsCharacterEnabled,
                EekEvents.CompareTypes.IsCurrentlyBeingUsed,
                EekEvents.CompareTypes.IsCurrentlyUsing,
                EekEvents.CompareTypes.IsExplicitGameVersion,
                EekEvents.CompareTypes.IsInFrontOf,
                EekEvents.CompareTypes.IsInHouse,
                EekEvents.CompareTypes.IsNewGame,
                EekEvents.CompareTypes.IsOnlyInVicinityAndVisionOf,
                EekEvents.CompareTypes.IsOnlyInVicinityOf,
                EekEvents.CompareTypes.IsOnlyInVisionOf,
                EekEvents.CompareTypes.IsZoneEmpty,
                EekEvents.CompareTypes.Item,
                EekEvents.CompareTypes.ItemFromItemGroup,
                EekEvents.CompareTypes.MetByPlayer,
                EekEvents.CompareTypes.Never,
                EekEvents.CompareTypes.None,
                EekEvents.CompareTypes.Personality,
                EekEvents.CompareTypes.PlayerBeingSpokenTo,
                EekEvents.CompareTypes.PlayerGender,
                EekEvents.CompareTypes.PlayerInventory,
                EekEvents.CompareTypes.PlayerPrefs,
                EekEvents.CompareTypes.Posing,
                EekEvents.CompareTypes.Property,
                EekEvents.CompareTypes.Quest,
                EekEvents.CompareTypes.SameZoneAs,
                EekEvents.CompareTypes.Social,
                EekEvents.CompareTypes.State,
                EekEvents.CompareTypes.UseLegacyIntimacy,
                EekEvents.CompareTypes.Value,
                EekEvents.CompareTypes.Vision
            };
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

        private EekEvents.Stories.CharacterStoryData SelectedStory
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

        private int DisplayNumberBlock(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-")
        {
            GUILayout.BeginVertical(Opt);

            if (text.Length > 0) GUILayout.Box($"{text}: {number}", Opt);
            else GUILayout.Box($"{number}", Opt);

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

        private int DisplayNumberHorizontal(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-")
        {
            GUILayout.BeginHorizontal(Opt);

            if (GUILayout.Button(minusButton, Opt) && number > min)
            {
                number--;
            }
            if (GUILayout.Button(plusButton, Opt) && number < max)
            {
                number++;
            }

            if (text.Length > 0) GUILayout.Box($"{text}: {number}", Opt);
            else GUILayout.Box($"{number}", Opt);

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            return number;
        }

        private int DisplayNumberVertical(int number, int min = 0, int max = int.MaxValue, string text = "", string plusButton = "+", string minusButton = "-")
        {
            GUILayout.BeginVertical(Opt);

            if (text.Length > 0) GUILayout.Box($"{text}: {number}", Opt);
            else GUILayout.Box($"{number}", Opt);

            if (GUILayout.Button(minusButton, Opt) && number > min)
            {
                number--;
            }
            if (GUILayout.Button(plusButton, Opt) && number < max)
            {
                number++;
            }

            GUILayout.EndVertical();

            return number;
        }

        private EekEvents.CompareTypes DisplayCompareTypes(EekEvents.CompareTypes type)
        {
            GUILayout.BeginVertical(Opt);
            int index = 0;
            foreach (EekEvents.CompareTypes item in CompareTypesArray)
            {
                if (item == type)
                {
                    break;
                }
                index++;
            }

            //display compare type and selection
            index = DisplayNumberBlock(index, 0, CompareTypesArray.Length - 1, CompareTypesArray[index].ToString(), ">", "<");

            type = CompareTypesArray[index];

            GUILayout.EndVertical();

            return type;
        }

        private string DisplayCharacterSelector(string character)
        {
            GUILayout.BeginVertical(Opt);
            int index = 0;
            foreach (string item in Characters)
            {
                if (item == character)
                {
                    break;
                }
                index++;
            }

            //display compare type and selection
            index = DisplayNumberHorizontal(index, 0, Characters.Length - 1, $"Speaking To {Characters[index]}", ">", "<");

            character = Characters[index];

            GUILayout.EndVertical();

            return character;
        }

        private EekEvents.Criteria DisplayComparisonFields(EekEvents.Criteria criterion)
        {
            switch (criterion.CompareType)
            {
                case EekEvents.CompareTypes.Never:
                    //Nothing?
                    break;
                case EekEvents.CompareTypes.Clothing:
                    //character as character for condition, clothing as value, clothing set as option (none 0, number afterwards), boolvalue as value
                    break;
                case EekEvents.CompareTypes.CoinFlip:
                    //nothing needed, its 50/50 anyways
                    break;
                case EekEvents.CompareTypes.CompareValues:
                    //character as character, character as character2, comparison as valueformula, value1 as key, value2 as key2
                    break;
                case EekEvents.CompareTypes.CriteriaGroup:
                    //criteriagroup(id) as key, true/false as option (0/1)
                    break;
                case EekEvents.CompareTypes.CutScene:
                    //todo: no idea what is needed
                    break;
                case EekEvents.CompareTypes.Dialogue:
                    //Character as character, dialogie id as value, dialogue status as dialogue status
                    break;
                case EekEvents.CompareTypes.Distance:
                    //object name 1 as key, object name 2 as key2, equal value as equationvalue, distance as value
                    break;
                case EekEvents.CompareTypes.Door:
                    //dor name as key, door option as dooroption
                    break;
                case EekEvents.CompareTypes.IntimacyPartner:
                    //character as charater, equals value as equalsvalue, character 2 as value 
                    break;
                case EekEvents.CompareTypes.IntimacyState:
                    //character as character, equals vlaue as equalsvalue, state as value
                    break;
                case EekEvents.CompareTypes.InZone:
                    //character as character, zone name as key, state as boolvalue
                    break;
                case EekEvents.CompareTypes.InVicinity:
                    //character as character, character as character2, state as boolvalue
                    break;
                case EekEvents.CompareTypes.InVicinityAndVision:
                    //same as invicinity
                    break;
                case EekEvents.CompareTypes.Item:
                    //item as key, item comparison as itemcomparison, character as character, state as boolvalue
                    //or it not involved with characters(no "To/By")
                    //item as key, item comparison as itemcomparison, state as boolvalue
                    break;
                case EekEvents.CompareTypes.IsOnlyInVicinityOf:
                    //same as invicinity
                    break;
                case EekEvents.CompareTypes.IsOnlyInVisionOf:
                    //same as invicinity
                    break;
                case EekEvents.CompareTypes.IsOnlyInVicinityAndVisionOf:
                    //same as invicinity
                    break;
                case EekEvents.CompareTypes.IsAloneWithPlayer:
                    //character as character, value as boolvalue
                    break;
                case EekEvents.CompareTypes.IsCharacterEnabled:
                    //character as character, value as boolvalue
                    break;
                case EekEvents.CompareTypes.IsCurrentlyBeingUsed:
                    //item name as key, value as boolvalue
                    break;
                case EekEvents.CompareTypes.IsCurrentlyUsing:
                    //character as character, item as key, state as boolvalue
                    break;
                case EekEvents.CompareTypes.IsExplicitGameVersion:
                    //state as boolvalue
                    break;
                case EekEvents.CompareTypes.IsInFrontOf:
                    //character as character2, characetr as character, state as boolvalue
                    break;
                case EekEvents.CompareTypes.IsInHouse:
                    //character as character, state as boolvalue
                    break;
                case EekEvents.CompareTypes.IsNewGame:
                    //state as boolvalue
                    break;
                case EekEvents.CompareTypes.IsZoneEmpty:
                    //zone as key, state as boolvalue
                    break;
                case EekEvents.CompareTypes.ItemFromItemGroup:
                    //greyed out in csc
                    break;
                case EekEvents.CompareTypes.MetByPlayer:
                    //character as character, value as boolvalue
                    break;
                case EekEvents.CompareTypes.Personality:
                    //character as character, personality type as key, comparison as equationvalue, value as boolvalue
                    break;
                case EekEvents.CompareTypes.IsBeingSpokenTo:
                    //character as character, value as boolvalue
                    break;
                case EekEvents.CompareTypes.PlayerBeingSpokenTo:
                    //value as boolvalue
                    break;
                case EekEvents.CompareTypes.PlayerGender:
                    //gender as value
                    break;
                case EekEvents.CompareTypes.PlayerInventory:
                    //has item: item as key, value as boolvalue
                    //has at least one item: value as boolvalue
                    break;
                case EekEvents.CompareTypes.Posing:
                    //is currently posing: character as character, value as boolvalue
                    //current pose: character as character, pose id as value, value as boolvalue
                    break;
                case EekEvents.CompareTypes.Property:
                    //character as character, property id as value, value as boolvalue
                    break;
                case EekEvents.CompareTypes.Quest:
                    //quest id as key, quest name as key2, value as boolvalue
                    break;
                case EekEvents.CompareTypes.SameZoneAs:
                    //character as character, character as character2, value as boolvalue
                    break;
                case EekEvents.CompareTypes.Social:
                    //for one: character as character, status as social status, comparison as equationvalue, value as value
                    //for two: character as character, character as character2, status as social status, comparison as equationvalue, value as value
                    break;
                case EekEvents.CompareTypes.State:
                    //character as character, state id as value, value as boolvalue
                    break;
                case EekEvents.CompareTypes.Value:
                    //character as character, value name as key, comparison as equationvalue, value as value
                    break;
                case EekEvents.CompareTypes.Vision:
                    //character as character, character as character2, value as boolvalue
                    break;
                case EekEvents.CompareTypes.PlayerPrefs:
                    //value name as key, comparison as equationvalue, value as value
                    break;
                case EekEvents.CompareTypes.UseLegacyIntimacy:
                    //state as boolvalue
                    break;
                case EekEvents.CompareTypes.None:
                    //none, duh :)
                    break;
                default:
                    break;
            }

            return criterion;
        }

        private EekEvents.Criteria DuplicateCriterion(EekEvents.Criteria criterion)
        {
            EekEvents.Criteria tempCriterion = new EekEvents.Criteria
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

        private Il2CppSystem.Collections.Generic.List<EekEvents.Criteria> DisplayCriteria(Il2CppSystem.Collections.Generic.List<EekEvents.Criteria> criteria)
        {
            GUILayout.BeginHorizontal(Opt);
            GUILayout.Space(30f);

            GUILayout.BeginVertical(Opt);
            EekEvents.Criteria CriterionToDelete = null;
            EekEvents.Criteria CriterionToCopy = null;
            EekEvents.Criteria CriterionToMove = null;
            int MoveCriterionDirection = 0; // 1 is up, 2 is down, 0 nothing

            if (criteria.Count > 0)
            {
                foreach (EekEvents.Criteria criterion in criteria)
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

                    EekEvents.Criteria tempCriterion = DisplayComparisonFields(criterion);

                    //copy all fields, cant just copy the object or even use ref because we are in a for loop
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
                    else if (MoveCriterionDirection == 2 && index < criteria.Count - 2)
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
                criteria.Insert(0, new EekEvents.Criteria());
            }
            if (GUILayout.Button("Add Criteria Bottom", Opt))
            {
                criteria.Add(new EekEvents.Criteria());
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

            //other infos, layout is the same as in the csc
            dialogue.SpeakingToCharacterName = DisplayCharacterSelector(dialogue.SpeakingToCharacterName);
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

        //
        //overrides that get called
        //

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

        //every time ui is updated
        public override void OnGUI()
        {
            if (InGameMain && ShowEditor)
            {

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
                GameManager = UnityEngine.Object.FindObjectOfType<EekCharacterEngine.GameManager>();

                Stories = EekCharacterEngine.GameManager.GetCharacterStories();
                StoriesSet = true;

                //add stories to game
                foreach (var story in Stories)
                {
                    GameManager.RegisterCharacterStory(story);
                }
            }
        }

        //on start
        public override void OnApplicationStart()
        {
            EditorWindow = new Rect(EditorX, EditorY, EditorWidth, EditorHeight);
        }

        //on quit
        public override void OnApplicationQuit()
        {

        }
    }
}
