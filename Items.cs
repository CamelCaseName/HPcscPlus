using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerRuntimeLib;

namespace HPCSC
{
    public class Criterion : Object
    {
        private List<Object> instance = new List<Object>();

        public Criterion() : base(ClassInjector.DerivedConstructorPointer<Criterion>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            instance.Clear();
            instance = null;
        }

        public Criterion(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string boolValue;

        public string GetBoolValue()
        {
            return boolValue;
        }

        public void SetBoolValue(string value)
        {
            boolValue = value;
        }

        private string character;

        public string GetCharacter()
        {
            return character;
        }

        public void SetCharacter(string value)
        {
            character = value;
        }

        private string character2;

        public string GetCharacter2()
        {
            return character2;
        }

        public void SetCharacter2(string value)
        {
            character2 = value;
        }

        private string compareType;

        public string GetCompareType()
        {
            return compareType;
        }

        public void SetCompareType(string value)
        {
            compareType = value;
        }

        private string dialogueStatus;

        public string GetDialogueStatus()
        {
            return dialogueStatus;
        }

        public void SetDialogueStatus(string value)
        {
            dialogueStatus = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private string doorOptions;

        public string GetDoorOptions()
        {
            return doorOptions;
        }

        public void SetDoorOptions(string value)
        {
            doorOptions = value;
        }

        private string equalsValue;

        public string GetEqualsValue()
        {
            return equalsValue;
        }

        public void SetEqualsValue(string value)
        {
            equalsValue = value;
        }

        private string equationValue;

        public string GetEquationValue()
        {
            return equationValue;
        }

        public void SetEquationValue(string value)
        {
            equationValue = value;
        }

        private string valueFormula;

        public string GetValueFormula()
        {
            return valueFormula;
        }

        public void SetValueFormula(string value)
        {
            valueFormula = value;
        }

        private string itemComparison;

        public string GetItemComparison()
        {
            return itemComparison;
        }

        public void SetItemComparison(string value)
        {
            itemComparison = value;
        }

        private string itemFromItemGroupComparison;

        public string GetItemFromItemGroupComparison()
        {
            return itemFromItemGroupComparison;
        }

        public void SetItemFromItemGroupComparison(string value)
        {
            itemFromItemGroupComparison = value;
        }

        private string key;

        public string GetKey()
        {
            return key;
        }

        public void SetKey(string value)
        {
            key = value;
        }

        private string key2;

        public string GetKey2()
        {
            return key2;
        }

        public void SetKey2(string value)
        {
            key2 = value;
        }

        private int order;

        public int GetOrder()
        {
            return order;
        }

        public void SetOrder(int value)
        {
            order = value;
        }

        private string playerInventoryOption;

        public string GetPlayerInventoryOption()
        {
            return playerInventoryOption;
        }

        public void SetPlayerInventoryOption(string value)
        {
            playerInventoryOption = value;
        }

        private string poseOption;

        public string GetPoseOption()
        {
            return poseOption;
        }

        public void SetPoseOption(string value)
        {
            poseOption = value;
        }

        private string socialStatus;

        public string GetSocialStatus()
        {
            return socialStatus;
        }

        public void SetSocialStatus(string value)
        {
            socialStatus = value;
        }

        private string value;

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string value)
        {
            this.value = value;
        }

        private int option;

        public int GetOption()
        {
            return option;
        }

        public void SetOption(int value)
        {
            option = value;
        }
    }

    public class Event : Object
    {
        private List<Object> instance = new List<Object>();

        public Event() : base(ClassInjector.DerivedConstructorPointer<Event>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            instance.Clear();
            instance = null;
        }

        public Event(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }


        private int sortOrder2;

        public int GetSortOrder2()
        {
            return sortOrder2;
        }

        public void SetSortOrder2(int value)
        {
            sortOrder2 = value;
        }

        private string version;

        public string GetVersion()
        {
            return version;
        }

        public void SetVersion(string value)
        {
            version = value;
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private bool enabled;

        public bool GetEnabled()
        {
            return enabled;
        }

        public void SetEnabled(bool value)
        {
            enabled = value;
        }

        private int eventType;

        public int GetEventType()
        {
            return eventType;
        }

        public void SetEventType(int value)
        {
            eventType = value;
        }

        private string character;

        public string GetCharacter()
        {
            return character;
        }

        public void SetCharacter(string value)
        {
            character = value;
        }

        private string character2;

        public string GetCharacter2()
        {
            return character2;
        }

        public void SetCharacter2(string value)
        {
            character2 = value;
        }

        private string key;

        public string GetKey()
        {
            return key;
        }

        public void SetKey(string value)
        {
            key = value;
        }

        private int option;

        public int GetOption()
        {
            return option;
        }

        public void SetOption(int value)
        {
            option = value;
        }

        private int option2;

        public int GetOption2()
        {
            return option2;
        }

        public void SetOption2(int value)
        {
            option2 = value;
        }

        private int option3;

        public int GetOption3()
        {
            return option3;
        }

        public void SetOption3(int value)
        {
            option3 = value;
        }

        private string value;

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string value)
        {
            this.value = value;
        }

        private string value2;

        public string GetValue2()
        {
            return value2;
        }

        public void SetValue2(string value)
        {
            value2 = value;
        }

        private int sortOrder;

        public int GetSortOrder()
        {
            return sortOrder;
        }

        public void SetSortOrder(int value)
        {
            sortOrder = value;
        }

        private string delay;

        public string GetDelay()
        {
            return delay;
        }

        public void SetDelay(string value)
        {
            delay = value;
        }

        private string originalDelay;

        public string GetOriginalDelay()
        {
            return originalDelay;
        }

        public void SetOriginalDelay(string value)
        {
            originalDelay = value;
        }

        private string startDelayTime;

        public string GetStartDelayTime()
        {
            return startDelayTime;
        }

        public void SetStartDelayTime(string value)
        {
            startDelayTime = value;
        }

        private bool useConditions;

        public bool GetUseConditions()
        {
            return useConditions;
        }

        public void SetUseConditions(bool value)
        {
            useConditions = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private List<Criterion> criteria;

        public List<Criterion> GetCriteria()
        {
            return criteria;
        }

        public void SetCriteria(List<Criterion> value)
        {
            criteria = value;
        }
    }

    public class ItemAction : Object
    {
        private List<Object> instance = new List<Object>();

        public ItemAction() : base(ClassInjector.DerivedConstructorPointer<ItemAction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            foreach (var item in onTakeActionEvents)
            {
                item.Unload();
            }
            onTakeActionEvents = null;
            instance.Clear();
            instance = null;
        }

        public ItemAction(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }


        private string actionName;

        public string GetActionName()
        {
            return actionName;
        }

        public void SetActionName(string value)
        {
            actionName = value;
        }

        private List<Criterion> criteria;

        public List<Criterion> GetCriteria()
        {
            return criteria;
        }

        public void SetCriteria(List<Criterion> value)
        {
            criteria = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private List<Event> onTakeActionEvents;

        public List<Event> GetOnTakeActionEvents()
        {
            return onTakeActionEvents;
        }

        public void SetOnTakeActionEvents(List<Event> value)
        {
            onTakeActionEvents = value;
        }
    }

    public class UseWith : Object
    {
        private List<Object> instance = new List<Object>();

        public UseWith() : base(ClassInjector.DerivedConstructorPointer<UseWith>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            foreach (var item in onSuccessEvents)
            {
                item.Unload();
            }
            onSuccessEvents = null;
            instance.Clear();
            instance = null;
        }

        public UseWith(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private List<Criterion> criteria;

        public List<Criterion> GetCriteria()
        {
            return criteria;
        }

        public void SetCriteria(List<Criterion> value)
        {
            criteria = value;
        }

        private string customCantDoThatMessage;

        public string GetCustomCantDoThatMessage()
        {
            return customCantDoThatMessage;
        }

        public void SetCustomCantDoThatMessage(string value)
        {
            customCantDoThatMessage = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private string itemName;

        public string GetItemName()
        {
            return itemName;
        }

        public void SetItemName(string value)
        {
            itemName = value;
        }

        private List<Event> onSuccessEvents;

        public List<Event> GetOnSuccessEvents()
        {
            return onSuccessEvents;
        }

        public void SetOnSuccessEvents(List<Event> value)
        {
            onSuccessEvents = value;
        }
    }

    public class ItemOverride : Object
    {
        private List<Object> instance = new List<Object>();

        public ItemOverride() : base(ClassInjector.DerivedConstructorPointer<ItemOverride>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in itemActions)
            {
                item.Unload();
            }
            itemActions = null;
            foreach (var item in useWiths)
            {
                item.Unload();
            }
            useWiths = null;
            instance.Clear();
            instance = null;
        }

        public ItemOverride(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }


        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private string displayName;

        public string GetDisplayName()
        {
            return displayName;
        }

        public void SetDisplayName(string value)
        {
            displayName = value;
        }

        private List<ItemAction> itemActions;

        public List<ItemAction> GetItemActions()
        {
            return itemActions;
        }

        public void SetItemActions(List<ItemAction> value)
        {
            itemActions = value;
        }

        private string itemName;

        public string GetItemName()
        {
            return itemName;
        }

        public void SetItemName(string value)
        {
            itemName = value;
        }

        private List<UseWith> useWiths;

        public List<UseWith> GetUseWiths()
        {
            return useWiths;
        }

        public void SetUseWiths(List<UseWith> value)
        {
            useWiths = value;
        }

        private bool useDefaultRadialOptions;

        public bool GetUseDefaultRadialOptions()
        {
            return useDefaultRadialOptions;
        }

        public void SetUseDefaultRadialOptions(bool value)
        {
            useDefaultRadialOptions = value;
        }
    }

    public class ItemGroupBehavior : Object
    {
        private List<Object> instance = new List<Object>();

        public ItemGroupBehavior() : base(ClassInjector.DerivedConstructorPointer<ItemGroupBehavior>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in itemActions)
            {
                item.Unload();
            }
            itemActions = null;
            useWiths = null;
            instance.Clear();
            instance = null;
        }

        public ItemGroupBehavior(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }


        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private string groupName;

        public string GetGroupName()
        {
            return groupName;
        }

        public void SetGroupName(string value)
        {
            groupName = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private List<ItemAction> itemActions;

        public List<ItemAction> GetItemActions()
        {
            return itemActions;
        }

        public void SetItemActions(List<ItemAction> value)
        {
            itemActions = value;
        }

        private List<string> useWiths;

        public List<string> GetUseWiths()
        {
            return useWiths;
        }

        public void SetUseWiths(List<string> value)
        {
            useWiths = value;
        }
    }

    public class Achievement : Object
    {
        private List<Object> instance = new List<Object>();

        public Achievement() : base(ClassInjector.DerivedConstructorPointer<Achievement>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            instance.Clear();
            instance = null;
        }

        public Achievement(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }


        private string description;

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string image;

        public string GetImage()
        {
            return image;
        }

        public void SetImage(string value)
        {
            image = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private bool showInEditor;

        public bool GetShowInEditor()
        {
            return showInEditor;
        }

        public void SetShowInEditor(bool value)
        {
            showInEditor = value;
        }

        private string steamName;

        public string GetSteamName()
        {
            return steamName;
        }

        public void SetSteamName(string value)
        {
            steamName = value;
        }
    }

    public class CriteriaList : Object
    {
        private List<Object> instance = new List<Object>();

        public CriteriaList() : base(ClassInjector.DerivedConstructorPointer<CriteriaList>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in criteriaList)
            {
                item.Unload();
            }
            criteriaList = null;
            instance.Clear();
            instance = null;
        }

        public CriteriaList(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private List<Criterion> criteriaList;

        public List<Criterion> GetCriteriaList()
        {
            return criteriaList;
        }

        public void SetCriteriaList(List<Criterion> value)
        {
            criteriaList = value;
        }
    }

    public class CriteriaGroup : Object
    {
        private List<Object> instance = new List<Object>();

        public CriteriaGroup() : base(ClassInjector.DerivedConstructorPointer<CriteriaGroup>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in criteriaList)
            {
                item.Unload();
            }
            criteriaList = null;
            instance.Clear();
            instance = null;
        }

        public CriteriaGroup(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private string passCondition;

        public string GetPassCondition()
        {
            return passCondition;
        }

        public void SetPassCondition(string value)
        {
            passCondition = value;
        }

        private List<CriteriaList> criteriaList;

        public List<CriteriaList> GetCriteriaList()
        {
            return criteriaList;
        }

        public void SetCriteriaList(List<CriteriaList> value)
        {
            criteriaList = value;
        }
    }

    public class ItemGroup : Object
    {
        private List<Object> instance = new List<Object>();

        public ItemGroup() : base(ClassInjector.DerivedConstructorPointer<ItemGroup>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            itemsInGroup = null;
            instance.Clear();
            instance = null;
        }

        public ItemGroup(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private List<string> itemsInGroup;

        public List<string> GetItemsInGroup()
        {
            return itemsInGroup;
        }

        public void SetItemsInGroup(List<string> value)
        {
            itemsInGroup = value;
        }
    }

    public class PlayerReaction : Object
    {
        private List<Object> instance = new List<Object>();

        public PlayerReaction() : base(ClassInjector.DerivedConstructorPointer<PlayerReaction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in critera)
            {
                item.Unload();
            }
            critera = null;
            foreach (var item in events)
            {
                item.Unload();
            }
            events = null;
            instance.Clear();
            instance = null;
        }

        public PlayerReaction(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string characterToReactTo;

        public string GetCharacterToReactTo()
        {
            return characterToReactTo;
        }

        public void SetCharacterToReactTo(string value)
        {
            characterToReactTo = value;
        }

        private List<Criterion> critera;

        public List<Criterion> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Criterion> value)
        {
            critera = value;
        }

        private string currentIteration;

        public string GetCurrentIteration()
        {
            return currentIteration;
        }

        public void SetCurrentIteration(string value)
        {
            currentIteration = value;
        }

        private bool enabled;

        public bool GetEnabled()
        {
            return enabled;
        }

        public void SetEnabled(bool value)
        {
            enabled = value;
        }

        private List<Event> events;

        public List<Event> GetEvents()
        {
            return events;
        }

        public void SetEvents(List<Event> value)
        {
            events = value;
        }

        private string key;

        public string GetKey()
        {
            return key;
        }

        public void SetKey(string value)
        {
            key = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private bool showInInspector;

        public bool GetShowInInspector()
        {
            return showInInspector;
        }

        public void SetShowInInspector(bool value)
        {
            showInInspector = value;
        }

        private string type;

        public new string GetType()
        {
            return type;
        }

        public void SetType(string value)
        {
            type = value;
        }

        private string updateIteration;

        public string GetUpdateIteration()
        {
            return updateIteration;
        }

        public void SetUpdateIteration(string value)
        {
            updateIteration = value;
        }

        private string value;

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string value)
        {
            this.value = value;
        }

        private string locationTargetOption;

        public string GetLocationTargetOption()
        {
            return locationTargetOption;
        }

        public void SetLocationTargetOption(string value)
        {
            locationTargetOption = value;
        }
    }

    public class MainStory : Object
    {
        private List<Object> instance = new List<Object>();

        public MainStory() : base(ClassInjector.DerivedConstructorPointer<MainStory>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in itemOverrides)
            {
                item.Unload();
            }
            itemOverrides = null;
            foreach (var item in itemGroupBehaviors)
            {
                item.Unload();
            }
            itemGroupBehaviors = null;
            foreach (var item in achievements)
            {
                item.Unload();
            }
            achievements = null;
            foreach (var item in criteriaGroups)
            {
                item.Unload();
            }
            criteriaGroups = null;
            foreach (var item in itemGroups)
            {
                item.Unload();
            }
            itemGroups = null;
            foreach (var item in gameStartEvents)
            {
                item.Unload();
            }
            gameStartEvents = null;
            foreach (var item in playerReactions)
            {
                item.Unload();
            }
            playerReactions = null;
            instance.Clear();
            instance = null;
        }

        public MainStory(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string housePartyVersion;

        public string GetHousePartyVersion()
        {
            return housePartyVersion;
        }

        public void SetHousePartyVersion(string value)
        {
            housePartyVersion = value;
        }

        private List<ItemOverride> itemOverrides;

        public List<ItemOverride> GetItemOverrides()
        {
            return itemOverrides;
        }

        public void SetItemOverrides(List<ItemOverride> value)
        {
            itemOverrides = value;
        }

        private List<ItemGroupBehavior> itemGroupBehaviors;

        public List<ItemGroupBehavior> GetItemGroupBehaviors()
        {
            return itemGroupBehaviors;
        }

        public void SetItemGroupBehaviors(List<ItemGroupBehavior> value)
        {
            itemGroupBehaviors = value;
        }

        private List<Achievement> achievements;

        public List<Achievement> GetAchievements()
        {
            return achievements;
        }

        public void SetAchievements(List<Achievement> value)
        {
            achievements = value;
        }

        private List<string> playerValues;

        public List<string> GetPlayerValues()
        {
            return playerValues;
        }

        public void SetPlayerValues(List<string> value)
        {
            playerValues = value;
        }

        private List<CriteriaGroup> criteriaGroups;

        public List<CriteriaGroup> GetCriteriaGroups()
        {
            return criteriaGroups;
        }

        public void SetCriteriaGroups(List<CriteriaGroup> value)
        {
            criteriaGroups = value;
        }

        private List<ItemGroup> itemGroups;

        public List<ItemGroup> GetItemGroups()
        {
            return itemGroups;
        }

        public void SetItemGroups(List<ItemGroup> value)
        {
            itemGroups = value;
        }

        private List<Event> gameStartEvents;

        public List<Event> GetGameStartEvents()
        {
            return gameStartEvents;
        }

        public void SetGameStartEvents(List<Event> value)
        {
            gameStartEvents = value;
        }

        private List<PlayerReaction> playerReactions;

        public List<PlayerReaction> GetPlayerReactions()
        {
            return playerReactions;
        }

        public void SetPlayerReactions(List<PlayerReaction> value)
        {
            playerReactions = value;
        }

        //protected new string ToString => "this worked! :)";
    }

    public class AlternateText : Object
    {
        private List<Object> instance = new List<Object>();

        public AlternateText() : base(ClassInjector.DerivedConstructorPointer<AlternateText>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in critera)
            {
                item.Unload();
            }
            critera.Clear();
            critera = null;
            instance.Clear();
            instance = null;
        }

        public AlternateText(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private List<Criterion> critera;

        public List<Criterion> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Criterion> value)
        {
            critera = value;
        }

        private int order;

        public int GetOrder()
        {
            return order;
        }

        public void SetOrder(int value)
        {
            order = value;
        }

        private bool show;

        public bool GetShow()
        {
            return show;
        }

        public void SetShow(bool value)
        {
            show = value;
        }

        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string value)
        {
            text = value;
        }
    }

    public class Response : Object
    {
        private List<Object> instance = new List<Object>();

        public Response() : base(ClassInjector.DerivedConstructorPointer<Response>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in responseCriteria)
            {
                item.Unload();
            }
            responseCriteria.Clear();
            responseCriteria = null;
            foreach (var item in responseEvents)
            {
                item.Unload();
            }
            responseEvents.Clear();
            responseEvents = null;
            instance.Clear();
            instance = null;
        }

        public Response(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private bool selected;

        public bool GetSelected()
        {
            return selected;
        }

        public void SetSelected(bool value)
        {
            selected = value;
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private bool alwaysDisplay;

        public bool GetAlwaysDisplay()
        {
            return alwaysDisplay;
        }

        public void SetAlwaysDisplay(bool value)
        {
            alwaysDisplay = value;
        }

        private int next;

        public int GetNext()
        {
            return next;
        }

        public void SetNext(int value)
        {
            next = value;
        }

        private int order;

        public int GetOrder()
        {
            return order;
        }

        public void SetOrder(int value)
        {
            order = value;
        }

        private List<Criterion> responseCriteria;

        public List<Criterion> GetResponseCriteria()
        {
            return responseCriteria;
        }

        public void SetResponseCriteria(List<Criterion> value)
        {
            responseCriteria = value;
        }

        private List<Event> responseEvents;

        public List<Event> GetResponseEvents()
        {
            return responseEvents;
        }

        public void SetResponseEvents(List<Event> value)
        {
            responseEvents = value;
        }

        private bool show;

        public bool GetShow()
        {
            return show;
        }

        public void SetShow(bool value)
        {
            show = value;
        }

        private bool showResponseCriteria;

        public bool GetShowResponseCriteria()
        {
            return showResponseCriteria;
        }

        public void SetShowResponseCriteria(bool value)
        {
            showResponseCriteria = value;
        }

        private bool showResponseEvents;

        public bool GetShowResponseEvents()
        {
            return showResponseEvents;
        }

        public void SetShowResponseEvents(bool value)
        {
            showResponseEvents = value;
        }

        private bool testingCriteraOverride;

        public bool GetTestingCriteraOverride()
        {
            return testingCriteraOverride;
        }

        public void SetTestingCriteraOverride(bool value)
        {
            testingCriteraOverride = value;
        }

        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string value)
        {
            text = value;
        }

        private string characterName;

        public string GetCharacterName()
        {
            return characterName;
        }

        public void SetCharacterName(string value)
        {
            characterName = value;
        }

        private int chatterId;

        public int GetChatterId()
        {
            return chatterId;
        }

        public void SetChatterId(int value)
        {
            chatterId = value;
        }

        private bool showInInspector;

        public bool GetShowInInspector()
        {
            return showInInspector;
        }

        public void SetShowInInspector(bool value)
        {
            showInInspector = value;
        }
    }

    public class Dialogue : Object
    {
        private List<Object> instance = new List<Object>();

        public Dialogue() : base(ClassInjector.DerivedConstructorPointer<Dialogue>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in alternateTexts)
            {
                item.Unload();
            }
            alternateTexts.Clear();
            alternateTexts = null;
            foreach (var item in closeEvents)
            {
                item.Unload();
            }
            closeEvents.Clear();
            closeEvents = null;
            foreach (var item in responses)
            {
                item.Unload();
            }
            responses.Clear();
            responses = null;
            foreach (var item in startEvents)
            {
                item.Unload();
            }
            startEvents.Clear();
            startEvents = null;
            instance.Clear();
            instance = null;
        }

        public Dialogue(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private bool shown;

        public bool GetShown()
        {
            return shown;
        }

        public void SetShown(bool value)
        {
            shown = value;
        }

        private List<AlternateText> alternateTexts;

        public List<AlternateText> GetAlternateTexts()
        {
            return alternateTexts;
        }

        public void SetAlternateTexts(List<AlternateText> value)
        {
            alternateTexts = value;
        }

        private List<Event> closeEvents;

        public List<Event> GetCloseEvents()
        {
            return closeEvents;
        }

        public void SetCloseEvents(List<Event> value)
        {
            closeEvents = value;
        }

        private int iD;

        public int GetID()
        {
            return iD;
        }

        public void SetID(int value)
        {
            iD = value;
        }

        private bool important;

        public bool GetImportant()
        {
            return important;
        }

        public void SetImportant(bool value)
        {
            important = value;
        }

        private List<Response> responses;

        public List<Response> GetResponses()
        {
            return responses;
        }

        public void SetResponses(List<Response> value)
        {
            responses = value;
        }

        private bool showAcceptedItems;

        public bool GetShowAcceptedItems()
        {
            return showAcceptedItems;
        }

        public void SetShowAcceptedItems(bool value)
        {
            showAcceptedItems = value;
        }

        private bool showAlternateTexts;

        public bool GetShowAlternateTexts()
        {
            return showAlternateTexts;
        }

        public void SetShowAlternateTexts(bool value)
        {
            showAlternateTexts = value;
        }

        private bool showCloseValueAdjustments;

        public bool GetShowCloseValueAdjustments()
        {
            return showCloseValueAdjustments;
        }

        public void SetShowCloseValueAdjustments(bool value)
        {
            showCloseValueAdjustments = value;
        }

        private bool showCritera;

        public bool GetShowCritera()
        {
            return showCritera;
        }

        public void SetShowCritera(bool value)
        {
            showCritera = value;
        }

        private bool showGlobalGoodByeResponses;

        public bool GetShowGlobalGoodByeResponses()
        {
            return showGlobalGoodByeResponses;
        }

        public void SetShowGlobalGoodByeResponses(bool value)
        {
            showGlobalGoodByeResponses = value;
        }

        private bool playVoice;

        public bool GetPlayVoice()
        {
            return playVoice;
        }

        public void SetPlayVoice(bool value)
        {
            playVoice = value;
        }

        private int voiceID;

        public int GetVoiceID()
        {
            return voiceID;
        }

        public void SetVoiceID(int value)
        {
            voiceID = value;
        }

        private bool showGlobalResponses;

        public bool GetShowGlobalResponses()
        {
            return showGlobalResponses;
        }

        public void SetShowGlobalResponses(bool value)
        {
            showGlobalResponses = value;
        }

        private bool doesNotCountAsMet;

        public bool GetDoesNotCountAsMet()
        {
            return doesNotCountAsMet;
        }

        public void SetDoesNotCountAsMet(bool value)
        {
            doesNotCountAsMet = value;
        }

        private bool showResponses;

        public bool GetShowResponses()
        {
            return showResponses;
        }

        public void SetShowResponses(bool value)
        {
            showResponses = value;
        }

        private bool showStartValueAdjustments;

        public bool GetShowStartValueAdjustments()
        {
            return showStartValueAdjustments;
        }

        public void SetShowStartValueAdjustments(bool value)
        {
            showStartValueAdjustments = value;
        }

        private string speakingToCharacterName;

        public string GetSpeakingToCharacterName()
        {
            return speakingToCharacterName;
        }

        public void SetSpeakingToCharacterName(string value)
        {
            speakingToCharacterName = value;
        }

        private List<Event> startEvents;

        public List<Event> GetStartEvents()
        {
            return startEvents;
        }

        public void SetStartEvents(List<Event> value)
        {
            startEvents = value;
        }

        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string value)
        {
            text = value;
        }
    }

    public class GlobalGoodbyeResponse : Object
    {
        private List<Object> instance = new List<Object>();
        public GlobalGoodbyeResponse() : base(ClassInjector.DerivedConstructorPointer<GlobalGoodbyeResponse>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in responseCriteria)
            {
                item.Unload();
            }
            responseCriteria.Clear();
            responseCriteria = null;
            foreach (var item in responseEvents)
            {
                item.Unload();
            }
            responseEvents.Clear();
            responseEvents = null;
            instance.Clear();
            instance = null;
        }

        public GlobalGoodbyeResponse(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private bool selected;

        public bool GetSelected()
        {
            return selected;
        }

        public void SetSelected(bool value)
        {
            selected = value;
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private bool alwaysDisplay;

        public bool GetAlwaysDisplay()
        {
            return alwaysDisplay;
        }

        public void SetAlwaysDisplay(bool value)
        {
            alwaysDisplay = value;
        }

        private int next;

        public int GetNext()
        {
            return next;
        }

        public void SetNext(int value)
        {
            next = value;
        }

        private int order;

        public int GetOrder()
        {
            return order;
        }

        public void SetOrder(int value)
        {
            order = value;
        }

        private List<Criterion> responseCriteria;

        public List<Criterion> GetResponseCriteria()
        {
            return responseCriteria;
        }

        public void SetResponseCriteria(List<Criterion> value)
        {
            responseCriteria = value;
        }

        private List<Event> responseEvents;

        public List<Event> GetResponseEvents()
        {
            return responseEvents;
        }

        public void SetResponseEvents(List<Event> value)
        {
            responseEvents = value;
        }

        private bool show;

        public bool GetShow()
        {
            return show;
        }

        public void SetShow(bool value)
        {
            show = value;
        }

        private bool showResponseCriteria;

        public bool GetShowResponseCriteria()
        {
            return showResponseCriteria;
        }

        public void SetShowResponseCriteria(bool value)
        {
            showResponseCriteria = value;
        }

        private bool showResponseEvents;

        public bool GetShowResponseEvents()
        {
            return showResponseEvents;
        }

        public void SetShowResponseEvents(bool value)
        {
            showResponseEvents = value;
        }

        private bool testingCriteraOverride;

        public bool GetTestingCriteraOverride()
        {
            return testingCriteraOverride;
        }

        public void SetTestingCriteraOverride(bool value)
        {
            testingCriteraOverride = value;
        }

        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string value)
        {
            text = value;
        }
    }

    public class GlobalResponse : Object
    {
        private List<Object> instance = new List<Object>();

        public GlobalResponse() : base(ClassInjector.DerivedConstructorPointer<GlobalResponse>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in responseCriteria)
            {
                item.Unload();
            }
            responseCriteria.Clear();
            responseCriteria = null;
            foreach (var item in responseEvents)
            {
                item.Unload();
            }
            responseEvents.Clear();
            responseEvents = null;
            instance.Clear();
            instance = null;
        }

        public GlobalResponse(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private bool selected;

        public bool GetSelected()
        {
            return selected;
        }

        public void SetSelected(bool value)
        {
            selected = value;
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private bool alwaysDisplay;

        public bool GetAlwaysDisplay()
        {
            return alwaysDisplay;
        }

        public void SetAlwaysDisplay(bool value)
        {
            alwaysDisplay = value;
        }

        private int next;

        public int GetNext()
        {
            return next;
        }

        public void SetNext(int value)
        {
            next = value;
        }

        private int order;

        public int GetOrder()
        {
            return order;
        }

        public void SetOrder(int value)
        {
            order = value;
        }

        private List<Criterion> responseCriteria;

        public List<Criterion> GetResponseCriteria()
        {
            return responseCriteria;
        }

        public void SetResponseCriteria(List<Criterion> value)
        {
            responseCriteria = value;
        }

        private List<Event> responseEvents;

        public List<Event> GetResponseEvents()
        {
            return responseEvents;
        }

        public void SetResponseEvents(List<Event> value)
        {
            responseEvents = value;
        }

        private bool show;

        public bool GetShow()
        {
            return show;
        }

        public void SetShow(bool value)
        {
            show = value;
        }

        private bool showResponseCriteria;

        public bool GetShowResponseCriteria()
        {
            return showResponseCriteria;
        }

        public void SetShowResponseCriteria(bool value)
        {
            showResponseCriteria = value;
        }

        private bool showResponseEvents;

        public bool GetShowResponseEvents()
        {
            return showResponseEvents;
        }

        public void SetShowResponseEvents(bool value)
        {
            showResponseEvents = value;
        }

        private bool testingCriteraOverride;

        public bool GetTestingCriteraOverride()
        {
            return testingCriteraOverride;
        }

        public void SetTestingCriteraOverride(bool value)
        {
            testingCriteraOverride = value;
        }

        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string value)
        {
            text = value;
        }
    }

    public class BackgroundChatter : Object
    {
        private List<Object> instance = new List<Object>();

        public BackgroundChatter() : base(ClassInjector.DerivedConstructorPointer<BackgroundChatter>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in critera)
            {
                item.Unload();
            }
            critera.Clear();
            critera = null;
            foreach (var item in startEvents)
            {
                item.Unload();
            }
            startEvents.Clear();
            startEvents = null;
            foreach (var item in responses)
            {
                item.Unload();
            }
            responses.Clear();
            responses = null;
            instance.Clear();
            instance = null;
        }

        public BackgroundChatter(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        private string text;

        public string GetText()
        {
            return text;
        }

        public void SetText(string value)
        {
            text = value;
        }

        private List<Criterion> critera;

        public List<Criterion> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Criterion> value)
        {
            critera = value;
        }

        private bool isConversationStarter;

        public bool GetIsConversationStarter()
        {
            return isConversationStarter;
        }

        public void SetIsConversationStarter(bool value)
        {
            isConversationStarter = value;
        }

        private bool showInInspector;

        public bool GetShowInInspector()
        {
            return showInInspector;
        }

        public void SetShowInInspector(bool value)
        {
            showInInspector = value;
        }

        private string speakingTo;

        public string GetSpeakingTo()
        {
            return speakingTo;
        }

        public void SetSpeakingTo(string value)
        {
            speakingTo = value;
        }

        private bool overrideCombatRestriction;

        public bool GetOverrideCombatRestriction()
        {
            return overrideCombatRestriction;
        }

        public void SetOverrideCombatRestriction(bool value)
        {
            overrideCombatRestriction = value;
        }

        private List<Event> startEvents;

        public List<Event> GetStartEvents()
        {
            return startEvents;
        }

        public void SetStartEvents(List<Event> value)
        {
            startEvents = value;
        }

        private List<Response> responses;

        public List<Response> GetResponses()
        {
            return responses;
        }

        public void SetResponses(List<Response> value)
        {
            responses = value;
        }

        private string pairedEmote;

        public string GetPairedEmote()
        {
            return pairedEmote;
        }

        public void SetPairedEmote(string value)
        {
            pairedEmote = value;
        }

        private string defaultImportance;

        public string GetDefaultImportance()
        {
            return defaultImportance;
        }

        public void SetDefaultImportance(string value)
        {
            defaultImportance = value;
        }
    }

    public class Valuee : Object
    {
        private List<Object> instance = new List<Object>();

        public Valuee() : base(ClassInjector.DerivedConstructorPointer<Valuee>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            instance.Clear();
            instance = null;
        }

        public Valuee(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string type;

        public new string GetType()
        {
            return type;
        }

        public void SetType(string value)
        {
            type = value;
        }

        private int value;

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }
    }

    public class Personality : Object
    {
        private List<Object> instance = new List<Object>();

        public Personality() : base(ClassInjector.DerivedConstructorPointer<Personality>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in values)
            {
                item.Unload();
            }
            values.Clear();
            values = null;
            instance.Clear();
            instance = null;
        }

        public Personality(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private List<Valuee> values;

        public List<Valuee> GetValues()
        {
            return values;
        }

        public void SetValues(List<Valuee> value)
        {
            values = value;
        }
    }

    public class ExtendedDetail : Object
    {
        private List<Object> instance = new List<Object>();

        public ExtendedDetail() : base(ClassInjector.DerivedConstructorPointer<ExtendedDetail>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            instance.Clear();
            instance = null;
        }

        public ExtendedDetail(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private int value;

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        private string details;

        public string GetDetails()
        {
            return details;
        }

        public void SetDetails(string value)
        {
            details = value;
        }
    }

    public class Quest : Object
    {
        private List<Object> instance = new List<Object>();

        public Quest() : base(ClassInjector.DerivedConstructorPointer<Quest>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in extendedDetails)
            {
                item.Unload();
            }
            extendedDetails.Clear();
            extendedDetails = null;
            instance.Clear();
            instance = null;
        }

        public Quest(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string characterName;

        public string GetCharacterName()
        {
            return characterName;
        }

        public void SetCharacterName(string value)
        {
            characterName = value;
        }

        private int completeAt;

        public int GetCompleteAt()
        {
            return completeAt;
        }

        public void SetCompleteAt(int value)
        {
            completeAt = value;
        }

        private int currentValue;

        public int GetCurrentValue()
        {
            return currentValue;
        }

        public void SetCurrentValue(int value)
        {
            currentValue = value;
        }

        private string details;

        public string GetDetails()
        {
            return details;
        }

        public void SetDetails(string value)
        {
            details = value;
        }

        private string completedDetails;

        public string GetCompletedDetails()
        {
            return completedDetails;
        }

        public void SetCompletedDetails(string value)
        {
            completedDetails = value;
        }

        private string failedDetails;

        public string GetFailedDetails()
        {
            return failedDetails;
        }

        public void SetFailedDetails(string value)
        {
            failedDetails = value;
        }

        private List<ExtendedDetail> extendedDetails;

        public List<ExtendedDetail> GetExtendedDetails()
        {
            return extendedDetails;
        }

        public void SetExtendedDetails(List<ExtendedDetail> value)
        {
            extendedDetails = value;
        }

        private string iD;

        public string GetID()
        {
            return iD;
        }

        public void SetID(string value)
        {
            iD = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private bool obtainOnStart;

        public bool GetObtainOnStart()
        {
            return obtainOnStart;
        }

        public void SetObtainOnStart(bool value)
        {
            obtainOnStart = value;
        }

        private bool seenByPlayer;

        public bool GetSeenByPlayer()
        {
            return seenByPlayer;
        }

        public void SetSeenByPlayer(bool value)
        {
            seenByPlayer = value;
        }

        private bool showProgress;

        public bool GetShowProgress()
        {
            return showProgress;
        }

        public void SetShowProgress(bool value)
        {
            showProgress = value;
        }

        private string status;

        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string value)
        {
            status = value;
        }

        private int obtainedDateTime;

        public int GetObtainedDateTime()
        {
            return obtainedDateTime;
        }

        public void SetObtainedDateTime(int value)
        {
            obtainedDateTime = value;
        }

        private int lastUpdatedDateTime;

        public int GetLastUpdatedDateTime()
        {
            return lastUpdatedDateTime;
        }

        public void SetLastUpdatedDateTime(int value)
        {
            lastUpdatedDateTime = value;
        }

        private bool showInInspector;

        public bool GetShowInInspector()
        {
            return showInInspector;
        }

        public void SetShowInInspector(bool value)
        {
            showInInspector = value;
        }
    }

    public class Reaction : Object
    {
        private List<Object> instance = new List<Object>();

        public Reaction() : base(ClassInjector.DerivedConstructorPointer<Reaction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in critera)
            {
                item.Unload();
            }
            critera.Clear();
            critera = null;
            foreach (var item in events)
            {
                item.Unload();
            }
            events.Clear();
            events = null;
            instance.Clear();
            instance = null;
        }

        public Reaction(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string characterToReactTo;

        public string GetCharacterToReactTo()
        {
            return characterToReactTo;
        }

        public void SetCharacterToReactTo(string value)
        {
            characterToReactTo = value;
        }

        private List<Criterion> critera;

        public List<Criterion> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Criterion> value)
        {
            critera = value;
        }

        private string currentIteration;

        public string GetCurrentIteration()
        {
            return currentIteration;
        }

        public void SetCurrentIteration(string value)
        {
            currentIteration = value;
        }

        private bool enabled;

        public bool GetEnabled()
        {
            return enabled;
        }

        public void SetEnabled(bool value)
        {
            enabled = value;
        }

        private List<Event> events;

        public List<Event> GetEvents()
        {
            return events;
        }

        public void SetEvents(List<Event> value)
        {
            events = value;
        }

        private string key;

        public string GetKey()
        {
            return key;
        }

        public void SetKey(string value)
        {
            key = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private bool showInInspector;

        public bool GetShowInInspector()
        {
            return showInInspector;
        }

        public void SetShowInInspector(bool value)
        {
            showInInspector = value;
        }

        private string type;

        public new string GetType()
        {
            return type;
        }

        public void SetType(string value)
        {
            type = value;
        }

        private string updateIteration;

        public string GetUpdateIteration()
        {
            return updateIteration;
        }

        public void SetUpdateIteration(string value)
        {
            updateIteration = value;
        }

        private string value;

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string value)
        {
            this.value = value;
        }

        private string locationTargetOption;

        public string GetLocationTargetOption()
        {
            return locationTargetOption;
        }

        public void SetLocationTargetOption(string value)
        {
            locationTargetOption = value;
        }
    }

    public class StoryItem : Object
    {
        private List<Object> instance = new List<Object>();

        public StoryItem() : base(ClassInjector.DerivedConstructorPointer<StoryItem>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in critera)
            {
                item.Unload();
            }
            critera.Clear();
            critera = null;
            foreach (var item in onAcceptEvents)
            {
                item.Unload();
            }
            onAcceptEvents.Clear();
            onAcceptEvents = null;
            foreach (var item in onRefuseEvents)
            {
                item.Unload();
            }
            onRefuseEvents.Clear();
            onRefuseEvents = null;
            instance.Clear();
            instance = null;
        }

        public StoryItem(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private List<Criterion> critera;

        public List<Criterion> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Criterion> value)
        {
            critera = value;
        }

        private string itemName;

        public string GetItemName()
        {
            return itemName;
        }

        public void SetItemName(string value)
        {
            itemName = value;
        }

        private List<Event> onAcceptEvents;

        public List<Event> GetOnAcceptEvents()
        {
            return onAcceptEvents;
        }

        public void SetOnAcceptEvents(List<Event> value)
        {
            onAcceptEvents = value;
        }

        private List<Event> onRefuseEvents;

        public List<Event> GetOnRefuseEvents()
        {
            return onRefuseEvents;
        }

        public void SetOnRefuseEvents(List<Event> value)
        {
            onRefuseEvents = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }
    }

    public class CharacterItemGroupInteraction : Object
    {
        private List<Object> instance = new List<Object>();

        public CharacterItemGroupInteraction() : base(ClassInjector.DerivedConstructorPointer<StoryItem>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria.Clear();
            criteria = null;
            foreach (var item in onAcceptEvents)
            {
                item.Unload();
            }
            onAcceptEvents.Clear();
            onAcceptEvents = null;
            foreach (var item in onRefuseEvents)
            {
                item.Unload();
            }
            onRefuseEvents.Clear();
            onRefuseEvents = null;
            instance.Clear();
            instance = null;
        }

        public CharacterItemGroupInteraction(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string id;

        public string GetId()
        {
            return id;
        }

        public void SetId(string value)
        {
            id = value;
        }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private string groupName;

        public string GetGroupName()
        {
            return groupName;
        }

        public void SetGroupName(string value)
        {
            groupName = value;
        }

        private bool displayInEditor;

        public bool GetDisplayInEditor()
        {
            return displayInEditor;
        }

        public void SetDisplayInEditor(bool value)
        {
            displayInEditor = value;
        }

        private List<Criterion> criteria;

        public List<Criterion> GetCriteria()
        {
            return criteria;
        }

        public void SetCriteria(List<Criterion> value)
        {
            criteria = value;
        }

        private List<Event> onAcceptEvents;

        public List<Event> GetOnAcceptEvents()
        {
            return onAcceptEvents;
        }

        public void SetOnAcceptEvents(List<Event> value)
        {
            onAcceptEvents = value;
        }

        private List<Event> onRefuseEvents;

        public List<Event> GetOnRefuseEvents()
        {
            return onRefuseEvents;
        }

        public void SetOnRefuseEvents(List<Event> value)
        {
            onRefuseEvents = value;
        }
    }

    public class CharacterStory : Object
    {
        private List<Object> instance = new List<Object>();

        public CharacterStory() : base(ClassInjector.DerivedConstructorPointer<CharacterStory>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance.Add(this);
        }

        public void Unload()
        {
            foreach (var item in dialogues)
            {
                item.Unload();
            }
            dialogues.Clear();
            dialogues = null;
            foreach (var item in globalGoodbyeResponses)
            {
                item.Unload();
            }
            globalGoodbyeResponses.Clear();
            globalGoodbyeResponses = null;
            foreach (var item in globalResponses)
            {
                item.Unload();
            }
            globalResponses.Clear();
            globalResponses = null;
            foreach (var item in backgroundChatter)
            {
                item.Unload();
            }
            backgroundChatter.Clear();
            backgroundChatter = null;
            foreach (var item in quests)
            {
                item.Unload();
            }
            quests.Clear();
            quests = null;
            foreach (var item in reactions)
            {
                item.Unload();
            }
            reactions.Clear();
            reactions = null;
            foreach (var item in storyItems)
            {
                item.Unload();
            }
            storyItems.Clear();
            storyItems = null;
            characterItemGroupInteractions.Clear();
            characterItemGroupInteractions = null;
            storyValues.Clear();
            storyValues = null;
            personality.Unload();
            instance.Clear();
            instance = null;
        }

        public CharacterStory(System.IntPtr value) : base(value)
        {
            instance.Add(this);
        }

        private string characterName;

        public string GetCharacterName()
        {
            return characterName;
        }

        public void SetCharacterName(string value)
        {
            characterName = value;
        }

        private string currentAspect;

        public string GetCurrentAspect()
        {
            return currentAspect;
        }

        public void SetCurrentAspect(string value)
        {
            currentAspect = value;
        }

        private int dialogueID;

        public int GetDialogueID()
        {
            return dialogueID;
        }

        public void SetDialogueID(int value)
        {
            dialogueID = value;
        }

        private List<Dialogue> dialogues;

        public List<Dialogue> GetDialogues()
        {
            return dialogues;
        }

        public void SetDialogues(List<Dialogue> value)
        {
            dialogues = value;
        }

        private List<GlobalGoodbyeResponse> globalGoodbyeResponses;

        public List<GlobalGoodbyeResponse> GetGlobalGoodbyeResponses()
        {
            return globalGoodbyeResponses;
        }

        public void SetGlobalGoodbyeResponses(List<GlobalGoodbyeResponse> value)
        {
            globalGoodbyeResponses = value;
        }

        private List<GlobalResponse> globalResponses;

        public List<GlobalResponse> GetGlobalResponses()
        {
            return globalResponses;
        }

        public void SetGlobalResponses(List<GlobalResponse> value)
        {
            globalResponses = value;
        }

        private string housePartyVersion;

        public string GetHousePartyVersion()
        {
            return housePartyVersion;
        }

        public void SetHousePartyVersion(string value)
        {
            housePartyVersion = value;
        }

        private List<BackgroundChatter> backgroundChatter;

        public List<BackgroundChatter> GetBackgroundChatter()
        {
            return backgroundChatter;
        }

        public void SetBackgroundChatter(List<BackgroundChatter> value)
        {
            backgroundChatter = value;
        }

        private bool lockCharacterSelection;

        public bool GetLockCharacterSelection()
        {
            return lockCharacterSelection;
        }

        public void SetLockCharacterSelection(bool value)
        {
            lockCharacterSelection = value;
        }

        private Personality personality;

        public Personality GetPersonality()
        {
            return personality;
        }

        public void SetPersonality(Personality value)
        {
            personality = value;
        }

        private List<Quest> quests;

        public List<Quest> GetQuests()
        {
            return quests;
        }

        public void SetQuests(List<Quest> value)
        {
            quests = value;
        }

        private List<Reaction> reactions;

        public List<Reaction> GetReactions()
        {
            return reactions;
        }

        public void SetReactions(List<Reaction> value)
        {
            reactions = value;
        }

        private List<StoryItem> storyItems;

        public List<StoryItem> GetStoryItems()
        {
            return storyItems;
        }

        public void SetStoryItems(List<StoryItem> value)
        {
            storyItems = value;
        }

        private List<CharacterItemGroupInteraction> characterItemGroupInteractions;

        public List<CharacterItemGroupInteraction> GetCharacterItemGroupInteractions()
        {
            return characterItemGroupInteractions;
        }

        public void SetCharacterItemGroupInteractions(List<CharacterItemGroupInteraction> value)
        {
            characterItemGroupInteractions = value;
        }

        private List<string> storyValues;

        public List<string> GetStoryValues()
        {
            return storyValues;
        }

        public void SetStoryValues(List<string> value)
        {
            storyValues = value;
        }
    }

}
