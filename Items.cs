using EekCharacterEngine.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

public class Criterion : Object
{
    public Criterion()
    {
    }

    public Criterion(System.IntPtr ptr) : base(ptr) { }

    public Criterion(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, EekEvents.ItemComparisonTypes itemComparison, InteractiveItem itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option)
    {
        BoolValue = boolValue;
        Character = character;
        Character2 = character2;
        CompareType = compareType;
        DialogueStatus = dialogueStatus;
        DisplayInEditor = displayInEditor;
        DoorOptions = doorOptions;
        EqualsValue = equalsValue;
        EquationValue = equationValue;
        ValueFormula = valueFormula;
        ItemComparison = itemComparison;
        ItemFromItemGroupComparison = itemFromItemGroupComparison;
        Key = key;
        Key2 = key2;
        Order = order;
        PlayerInventoryOption = playerInventoryOption;
        PoseOption = poseOption;
        SocialStatus = socialStatus;
        Value = value;
        Option = option;
    }

    public string BoolValue { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string CompareType { get; set; }
    public string DialogueStatus { get; set; }
    public bool DisplayInEditor { get; set; }
    public string DoorOptions { get; set; }
    public string EqualsValue { get; set; }
    public string EquationValue { get; set; }
    public string ValueFormula { get; set; }
    public EekEvents.ItemComparisonTypes ItemComparison { get; set; }
    public InteractiveItem ItemFromItemGroupComparison { get; set; }
    public string Key { get; set; }
    public string Key2 { get; set; }
    public int Order { get; set; }
    public string PlayerInventoryOption { get; set; }
    public string PoseOption { get; set; }
    public string SocialStatus { get; set; }
    public string Value { get; set; }
    public int Option { get; set; }
}

public class OnTakeActionEvent : Object
{
    public OnTakeActionEvent()
    {
    }

    public OnTakeActionEvent(System.IntPtr ptr) : base(ptr) { }

    public OnTakeActionEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class ItemAction : Object
{
    public ItemAction()
    {
    }

    public ItemAction(System.IntPtr ptr) : base(ptr) { }

    public ItemAction(string actionName, List<Criterion> criteria, bool displayInEditor, List<OnTakeActionEvent> onTakeActionEvents)
    {
        ActionName = actionName;
        Criteria = criteria;
        DisplayInEditor = displayInEditor;
        OnTakeActionEvents = onTakeActionEvents;
    }

    public string ActionName { get; set; }
    public List<Criterion> Criteria { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<OnTakeActionEvent> OnTakeActionEvents { get; set; }
}

public class OnSuccessEvent : Object
{
    public OnSuccessEvent()
    {
    }

    public OnSuccessEvent(System.IntPtr ptr) : base(ptr) { }

    public OnSuccessEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class UseWith : Object
{
    public UseWith()
    {
    }

    public UseWith(System.IntPtr ptr) : base(ptr) { }

    public UseWith(List<Criterion> criteria, string customCantDoThatMessage, bool displayInEditor, string itemName, List<OnSuccessEvent> onSuccessEvents)
    {
        Criteria = criteria;
        CustomCantDoThatMessage = customCantDoThatMessage;
        DisplayInEditor = displayInEditor;
        ItemName = itemName;
        OnSuccessEvents = onSuccessEvents;
    }

    public List<Criterion> Criteria { get; set; }
    public string CustomCantDoThatMessage { get; set; }
    public bool DisplayInEditor { get; set; }
    public string ItemName { get; set; }
    public List<OnSuccessEvent> OnSuccessEvents { get; set; }
}

public class ItemOverride : Object
{
    public ItemOverride()
    {
    }

    public ItemOverride(System.IntPtr ptr) : base(ptr) { }

    public ItemOverride(string id, bool displayInEditor, string displayName, List<ItemAction> itemActions, string itemName, List<UseWith> useWiths, bool useDefaultRadialOptions)
    {
        Id = id;
        DisplayInEditor = displayInEditor;
        DisplayName = displayName;
        ItemActions = itemActions;
        ItemName = itemName;
        UseWiths = useWiths;
        UseDefaultRadialOptions = useDefaultRadialOptions;
    }

    public string Id { get; set; }
    public bool DisplayInEditor { get; set; }
    public string DisplayName { get; set; }
    public List<ItemAction> ItemActions { get; set; }
    public string ItemName { get; set; }
    public List<UseWith> UseWiths { get; set; }
    public bool UseDefaultRadialOptions { get; set; }
}

public class ItemGroupBehavior : Object
{
    public ItemGroupBehavior()
    {
    }

    public ItemGroupBehavior(System.IntPtr ptr) : base(ptr) { }

    public ItemGroupBehavior(string id, string name, string groupName, bool displayInEditor, List<ItemAction> itemActions, List<string> useWiths)
    {
        Id = id;
        Name = name;
        GroupName = groupName;
        DisplayInEditor = displayInEditor;
        ItemActions = itemActions;
        UseWiths = useWiths;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public string GroupName { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<ItemAction> ItemActions { get; set; }
    public List<string> UseWiths { get; set; }
}

public class Achievement : Object
{
    public Achievement()
    {
    }

    public Achievement(System.IntPtr ptr) : base(ptr) { }

    public Achievement(string description, string id, string image, string name, bool showInEditor, string steamName)
    {
        Description = description;
        Id = id;
        Image = image;
        Name = name;
        ShowInEditor = showInEditor;
        SteamName = steamName;
    }

    public string Description { get; set; }
    public string Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public bool ShowInEditor { get; set; }
    public string SteamName { get; set; }
}

public class CriteriaList2 : Object
{
    public CriteriaList2()
    {
    }

    public CriteriaList2(System.IntPtr ptr) : base(ptr) { }

    public CriteriaList2(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, EekEvents.ItemComparisonTypes itemComparison, InteractiveItem itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option)
    {
        BoolValue = boolValue;
        Character = character;
        Character2 = character2;
        CompareType = compareType;
        DialogueStatus = dialogueStatus;
        DisplayInEditor = displayInEditor;
        DoorOptions = doorOptions;
        EqualsValue = equalsValue;
        EquationValue = equationValue;
        ValueFormula = valueFormula;
        ItemComparison = itemComparison;
        ItemFromItemGroupComparison = itemFromItemGroupComparison;
        Key = key;
        Key2 = key2;
        Order = order;
        PlayerInventoryOption = playerInventoryOption;
        PoseOption = poseOption;
        SocialStatus = socialStatus;
        Value = value;
        Option = option;
    }

    public string BoolValue { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string CompareType { get; set; }
    public string DialogueStatus { get; set; }
    public bool DisplayInEditor { get; set; }
    public string DoorOptions { get; set; }
    public string EqualsValue { get; set; }
    public string EquationValue { get; set; }
    public string ValueFormula { get; set; }
    public EekEvents.ItemComparisonTypes ItemComparison { get; set; }
    public EekCharacterEngine.Interaction.InteractiveItem ItemFromItemGroupComparison { get; set; }
    public string Key { get; set; }
    public string Key2 { get; set; }
    public int Order { get; set; }
    public string PlayerInventoryOption { get; set; }
    public string PoseOption { get; set; }
    public string SocialStatus { get; set; }
    public string Value { get; set; }
    public int Option { get; set; }
}

public class CriteriaList1 : Object
{
    public CriteriaList1()
    {
    }

    public CriteriaList1(System.IntPtr ptr) : base(ptr) { }

    public CriteriaList1(List<CriteriaList2> criteriaList)
    {
        CriteriaList = criteriaList;
    }

    public List<CriteriaList2> CriteriaList { get; set; }
}

public class CriteriaGroup : Object
{
    public CriteriaGroup()
    {
    }

    public CriteriaGroup(System.IntPtr ptr) : base(ptr) { }

    public CriteriaGroup(string id, string name, bool displayInEditor, string passCondition, List<CriteriaList1> criteriaList)
    {
        Id = id;
        Name = name;
        DisplayInEditor = displayInEditor;
        PassCondition = passCondition;
        CriteriaList = criteriaList;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public bool DisplayInEditor { get; set; }
    public string PassCondition { get; set; }
    public List<CriteriaList1> CriteriaList { get; set; }
}

public class ItemGroup : Object
{
    public ItemGroup()
    {
    }

    public ItemGroup(System.IntPtr ptr) : base(ptr) { }

    public ItemGroup(string id, string name, bool displayInEditor, List<string> itemsInGroup)
    {
        Id = id;
        Name = name;
        DisplayInEditor = displayInEditor;
        ItemsInGroup = itemsInGroup;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<string> ItemsInGroup { get; set; }
}

public class GameStartEvent : Object
{
    public GameStartEvent()
    {
    }

    public GameStartEvent(System.IntPtr ptr) : base(ptr) { }

    public GameStartEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class Critera : Object
{
    public Critera()
    {
    }

    public Critera(System.IntPtr ptr) : base(ptr) { }

    public Critera(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, EekEvents.ItemComparisonTypes itemComparison, InteractiveItem itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option)
    {
        BoolValue = boolValue;
        Character = character;
        Character2 = character2;
        CompareType = compareType;
        DialogueStatus = dialogueStatus;
        DisplayInEditor = displayInEditor;
        DoorOptions = doorOptions;
        EqualsValue = equalsValue;
        EquationValue = equationValue;
        ValueFormula = valueFormula;
        ItemComparison = itemComparison;
        ItemFromItemGroupComparison = itemFromItemGroupComparison;
        Key = key;
        Key2 = key2;
        Order = order;
        PlayerInventoryOption = playerInventoryOption;
        PoseOption = poseOption;
        SocialStatus = socialStatus;
        Value = value;
        Option = option;
    }

    public string BoolValue { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string CompareType { get; set; }
    public string DialogueStatus { get; set; }
    public bool DisplayInEditor { get; set; }
    public string DoorOptions { get; set; }
    public string EqualsValue { get; set; }
    public string EquationValue { get; set; }
    public string ValueFormula { get; set; }
    public EekEvents.ItemComparisonTypes ItemComparison { get; set; }
    public EekCharacterEngine.Interaction.InteractiveItem ItemFromItemGroupComparison { get; set; }
    public string Key { get; set; }
    public string Key2 { get; set; }
    public int Order { get; set; }
    public string PlayerInventoryOption { get; set; }
    public string PoseOption { get; set; }
    public string SocialStatus { get; set; }
    public string Value { get; set; }
    public int Option { get; set; }
}

public class Event : Object
{
    public Event()
    {
    }

    public Event(System.IntPtr ptr) : base(ptr) { }

    public Event(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class PlayerReaction : Object
{
    public PlayerReaction()
    {
    }

    public PlayerReaction(System.IntPtr ptr) : base(ptr) { }

    public PlayerReaction(string id, string characterToReactTo, List<Critera> critera, Double currentIteration, bool enabled, List<Event> events, string key, string name, bool showInInspector, string type, Double updateIteration, string value, string locationTargetOption)
    {
        Id = id;
        CharacterToReactTo = characterToReactTo;
        Critera = critera;
        CurrentIteration = currentIteration;
        Enabled = enabled;
        Events = events;
        Key = key;
        Name = name;
        ShowInInspector = showInInspector;
        Type = type;
        UpdateIteration = updateIteration;
        Value = value;
        LocationTargetOption = locationTargetOption;
    }

    public string Id { get; set; }
    public string CharacterToReactTo { get; set; }
    public List<Critera> Critera { get; set; }
    public Double CurrentIteration { get; set; }
    public bool Enabled { get; set; }
    public List<Event> Events { get; set; }
    public string Key { get; set; }
    public string Name { get; set; }
    public bool ShowInInspector { get; set; }
    public string Type { get; set; }
    public Double UpdateIteration { get; set; }
    public string Value { get; set; }
    public string LocationTargetOption { get; set; }
}

public class MainStory : Object
{
    public MainStory()
    {
    }

    public MainStory(System.IntPtr ptr) : base(ptr) { }

    public MainStory(string housePartyVersion, List<ItemOverride> itemOverrides, List<ItemGroupBehavior> itemGroupBehaviors, List<Achievement> achievements, List<string> playerValues, List<CriteriaGroup> criteriaGroups, List<ItemGroup> itemGroups, List<GameStartEvent> gameStartEvents, List<PlayerReaction> playerReactions)
    {
        HousePartyVersion = housePartyVersion;
        ItemOverrides = itemOverrides;
        ItemGroupBehaviors = itemGroupBehaviors;
        Achievements = achievements;
        PlayerValues = playerValues;
        CriteriaGroups = criteriaGroups;
        ItemGroups = itemGroups;
        GameStartEvents = gameStartEvents;
        PlayerReactions = playerReactions;
    }

    public string HousePartyVersion { get; set; }
    public List<ItemOverride> ItemOverrides { get; set; }
    public List<ItemGroupBehavior> ItemGroupBehaviors { get; set; }
    public List<Achievement> Achievements { get; set; }
    public List<string> PlayerValues { get; set; }
    public List<CriteriaGroup> CriteriaGroups { get; set; }
    public List<ItemGroup> ItemGroups { get; set; }
    public List<GameStartEvent> GameStartEvents { get; set; }
    public List<PlayerReaction> PlayerReactions { get; set; }
}

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public class AlternateText : Object
{
    public AlternateText()
    {
    }

    public AlternateText(System.IntPtr ptr) : base(ptr) { }

    public AlternateText(List<Critera> critera, int order, bool show, string text)
    {
        Critera = critera;
        Order = order;
        Show = show;
        Text = text;
    }

    public List<Critera> Critera { get; set; }
    public int Order { get; set; }
    public bool Show { get; set; }
    public string Text { get; set; }
}

public class CloseEvent : Object
{
    public CloseEvent()
    {
    }

    public CloseEvent(System.IntPtr ptr) : base(ptr) { }

    public CloseEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class ResponseCriteria : Object
{
    public ResponseCriteria()
    {
    }

    public ResponseCriteria(System.IntPtr ptr) : base(ptr) { }

    public ResponseCriteria(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, EekEvents.ItemComparisonTypes itemComparison, InteractiveItem itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option)
    {
        BoolValue = boolValue;
        Character = character;
        Character2 = character2;
        CompareType = compareType;
        DialogueStatus = dialogueStatus;
        DisplayInEditor = displayInEditor;
        DoorOptions = doorOptions;
        EqualsValue = equalsValue;
        EquationValue = equationValue;
        ValueFormula = valueFormula;
        ItemComparison = itemComparison;
        ItemFromItemGroupComparison = itemFromItemGroupComparison;
        Key = key;
        Key2 = key2;
        Order = order;
        PlayerInventoryOption = playerInventoryOption;
        PoseOption = poseOption;
        SocialStatus = socialStatus;
        Value = value;
        Option = option;
    }

    public string BoolValue { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string CompareType { get; set; }
    public string DialogueStatus { get; set; }
    public bool DisplayInEditor { get; set; }
    public string DoorOptions { get; set; }
    public string EqualsValue { get; set; }
    public string EquationValue { get; set; }
    public string ValueFormula { get; set; }
    public EekEvents.ItemComparisonTypes ItemComparison { get; set; }
    public EekCharacterEngine.Interaction.InteractiveItem ItemFromItemGroupComparison { get; set; }
    public string Key { get; set; }
    public string Key2 { get; set; }
    public int Order { get; set; }
    public string PlayerInventoryOption { get; set; }
    public string PoseOption { get; set; }
    public string SocialStatus { get; set; }
    public string Value { get; set; }
    public int Option { get; set; }
}

public class ResponseEvent : Object
{
    public ResponseEvent()
    {
    }

    public ResponseEvent(System.IntPtr ptr) : base(ptr) { }

    public ResponseEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class Response : Object
{
    public Response()
    {
    }

    public Response(System.IntPtr ptr) : base(ptr) { }

    public Response(bool selected, string id, bool alwaysDisplay, int next, int order, List<ResponseCriteria> responseCriteria, List<ResponseEvent> responseEvents, bool show, bool showResponseCriteria, bool showResponseEvents, bool testingCriteraOverride, string text, string characterName, int chatterId, bool showInInspector)
    {
        Selected = selected;
        Id = id;
        AlwaysDisplay = alwaysDisplay;
        Next = next;
        Order = order;
        ResponseCriteria = responseCriteria;
        ResponseEvents = responseEvents;
        Show = show;
        ShowResponseCriteria = showResponseCriteria;
        ShowResponseEvents = showResponseEvents;
        TestingCriteraOverride = testingCriteraOverride;
        Text = text;
        CharacterName = characterName;
        ChatterId = chatterId;
        ShowInInspector = showInInspector;
    }

    public bool Selected { get; set; }
    public string Id { get; set; }
    public bool AlwaysDisplay { get; set; }
    public int Next { get; set; }
    public int Order { get; set; }
    public List<ResponseCriteria> ResponseCriteria { get; set; }
    public List<ResponseEvent> ResponseEvents { get; set; }
    public bool Show { get; set; }
    public bool ShowResponseCriteria { get; set; }
    public bool ShowResponseEvents { get; set; }
    public bool TestingCriteraOverride { get; set; }
    public string Text { get; set; }
    public string CharacterName { get; set; }
    public int ChatterId { get; set; }
    public bool ShowInInspector { get; set; }
}

public class StartEvent : Object
{
    public StartEvent()
    {
    }

    public StartEvent(System.IntPtr ptr) : base(ptr) { }

    public StartEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class Dialogue : Object
{
    public Dialogue()
    {
    }

    public Dialogue(System.IntPtr ptr) : base(ptr) { }

    public Dialogue(bool shown, List<AlternateText> alternateTexts, List<CloseEvent> closeEvents, int iD, bool important, List<Response> responses, bool showAcceptedItems, bool showAlternateTexts, bool showCloseValueAdjustments, bool showCritera, bool showGlobalGoodByeResponses, bool playVoice, int voiceID, bool showGlobalResponses, bool doesNotCountAsMet, bool showResponses, bool showStartValueAdjustments, string speakingToCharacterName, List<StartEvent> startEvents, string text)
    {
        Shown = shown;
        AlternateTexts = alternateTexts;
        CloseEvents = closeEvents;
        ID = iD;
        Important = important;
        Responses = responses;
        ShowAcceptedItems = showAcceptedItems;
        ShowAlternateTexts = showAlternateTexts;
        ShowCloseValueAdjustments = showCloseValueAdjustments;
        ShowCritera = showCritera;
        ShowGlobalGoodByeResponses = showGlobalGoodByeResponses;
        PlayVoice = playVoice;
        VoiceID = voiceID;
        ShowGlobalResponses = showGlobalResponses;
        DoesNotCountAsMet = doesNotCountAsMet;
        ShowResponses = showResponses;
        ShowStartValueAdjustments = showStartValueAdjustments;
        SpeakingToCharacterName = speakingToCharacterName;
        StartEvents = startEvents;
        Text = text;
    }

    public bool Shown { get; set; }
    public List<AlternateText> AlternateTexts { get; set; }
    public List<CloseEvent> CloseEvents { get; set; }
    public int ID { get; set; }
    public bool Important { get; set; }
    public List<Response> Responses { get; set; }
    public bool ShowAcceptedItems { get; set; }
    public bool ShowAlternateTexts { get; set; }
    public bool ShowCloseValueAdjustments { get; set; }
    public bool ShowCritera { get; set; }
    public bool ShowGlobalGoodByeResponses { get; set; }
    public bool PlayVoice { get; set; }
    public int VoiceID { get; set; }
    public bool ShowGlobalResponses { get; set; }
    public bool DoesNotCountAsMet { get; set; }
    public bool ShowResponses { get; set; }
    public bool ShowStartValueAdjustments { get; set; }
    public string SpeakingToCharacterName { get; set; }
    public List<StartEvent> StartEvents { get; set; }
    public string Text { get; set; }
}

public class GlobalGoodbyeResponse : Object
{
    public GlobalGoodbyeResponse()
    {
    }

    public GlobalGoodbyeResponse(System.IntPtr ptr) : base(ptr) { }

    public GlobalGoodbyeResponse(bool selected, string id, bool alwaysDisplay, int next, int order, List<ResponseCriteria> responseCriteria, List<ResponseEvent> responseEvents, bool show, bool showResponseCriteria, bool showResponseEvents, bool testingCriteraOverride, string text)
    {
        Selected = selected;
        Id = id;
        AlwaysDisplay = alwaysDisplay;
        Next = next;
        Order = order;
        ResponseCriteria = responseCriteria;
        ResponseEvents = responseEvents;
        Show = show;
        ShowResponseCriteria = showResponseCriteria;
        ShowResponseEvents = showResponseEvents;
        TestingCriteraOverride = testingCriteraOverride;
        Text = text;
    }

    public bool Selected { get; set; }
    public string Id { get; set; }
    public bool AlwaysDisplay { get; set; }
    public int Next { get; set; }
    public int Order { get; set; }
    public List<ResponseCriteria> ResponseCriteria { get; set; }
    public List<ResponseEvent> ResponseEvents { get; set; }
    public bool Show { get; set; }
    public bool ShowResponseCriteria { get; set; }
    public bool ShowResponseEvents { get; set; }
    public bool TestingCriteraOverride { get; set; }
    public string Text { get; set; }
}

public class GlobalResponse : Object
{
    public GlobalResponse()
    {
    }

    public GlobalResponse(System.IntPtr ptr) : base(ptr) { }

    public GlobalResponse(bool selected, string id, bool alwaysDisplay, int next, int order, List<ResponseCriteria> responseCriteria, List<ResponseEvent> responseEvents, bool show, bool showResponseCriteria, bool showResponseEvents, bool testingCriteraOverride, string text)
    {
        Selected = selected;
        Id = id;
        AlwaysDisplay = alwaysDisplay;
        Next = next;
        Order = order;
        ResponseCriteria = responseCriteria;
        ResponseEvents = responseEvents;
        Show = show;
        ShowResponseCriteria = showResponseCriteria;
        ShowResponseEvents = showResponseEvents;
        TestingCriteraOverride = testingCriteraOverride;
        Text = text;
    }

    public bool Selected { get; set; }
    public string Id { get; set; }
    public bool AlwaysDisplay { get; set; }
    public int Next { get; set; }
    public int Order { get; set; }
    public List<ResponseCriteria> ResponseCriteria { get; set; }
    public List<ResponseEvent> ResponseEvents { get; set; }
    public bool Show { get; set; }
    public bool ShowResponseCriteria { get; set; }
    public bool ShowResponseEvents { get; set; }
    public bool TestingCriteraOverride { get; set; }
    public string Text { get; set; }
}

public class BackgroundChatter : Object
{
    public BackgroundChatter()
    {
    }

    public BackgroundChatter(System.IntPtr ptr) : base(ptr) { }

    public BackgroundChatter(int id, string text, List<Critera> critera, bool isConversationStarter, bool showInInspector, string speakingTo, bool overrideCombatRestriction, List<StartEvent> startEvents, List<Response> responses, string pairedEmote, string defaultImportance)
    {
        Id = id;
        Text = text;
        Critera = critera;
        IsConversationStarter = isConversationStarter;
        ShowInInspector = showInInspector;
        SpeakingTo = speakingTo;
        OverrideCombatRestriction = overrideCombatRestriction;
        StartEvents = startEvents;
        Responses = responses;
        PairedEmote = pairedEmote;
        DefaultImportance = defaultImportance;
    }

    public int Id { get; set; }
    public string Text { get; set; }
    public List<Critera> Critera { get; set; }
    public bool IsConversationStarter { get; set; }
    public bool ShowInInspector { get; set; }
    public string SpeakingTo { get; set; }
    public bool OverrideCombatRestriction { get; set; }
    public List<StartEvent> StartEvents { get; set; }
    public List<Response> Responses { get; set; }
    public string PairedEmote { get; set; }
    public string DefaultImportance { get; set; }
}

public class Valuee : Object
{
    public Valuee()
    {
    }

    public Valuee(System.IntPtr ptr) : base(ptr) { }

    public Valuee(string type, int value)
    {
        Type = type;
        Value = value;
    }

    public string Type { get; set; }
    public int Value { get; set; }
}

public class Personality : Object
{
    public Personality()
    {
    }

    public Personality(System.IntPtr ptr) : base(ptr) { }

    public Personality(List<Valuee> values)
    {
        Values = values;
    }

    public List<Valuee> Values { get; set; }
}

public class ExtendedDetail : Object
{
    public ExtendedDetail()
    {
    }

    public ExtendedDetail(System.IntPtr ptr) : base(ptr) { }

    public ExtendedDetail(int value, string details)
    {
        Value = value;
        Details = details;
    }

    public int Value { get; set; }
    public string Details { get; set; }
}

public class Quest : Object
{
    public Quest()
    {
    }

    public Quest(System.IntPtr ptr) : base(ptr) { }

    public Quest(string characterName, int completeAt, int currentValue, string details, string completedDetails, string failedDetails, List<ExtendedDetail> extendedDetails, string iD, string name, bool obtainOnStart, bool seenByPlayer, bool showProgress, string status, int obtainedDateTime, int lastUpdatedDateTime, bool showInInspector)
    {
        CharacterName = characterName;
        CompleteAt = completeAt;
        CurrentValue = currentValue;
        Details = details;
        CompletedDetails = completedDetails;
        FailedDetails = failedDetails;
        ExtendedDetails = extendedDetails;
        ID = iD;
        Name = name;
        ObtainOnStart = obtainOnStart;
        SeenByPlayer = seenByPlayer;
        ShowProgress = showProgress;
        Status = status;
        ObtainedDateTime = obtainedDateTime;
        LastUpdatedDateTime = lastUpdatedDateTime;
        ShowInInspector = showInInspector;
    }

    public string CharacterName { get; set; }
    public int CompleteAt { get; set; }
    public int CurrentValue { get; set; }
    public string Details { get; set; }
    public string CompletedDetails { get; set; }
    public string FailedDetails { get; set; }
    public List<ExtendedDetail> ExtendedDetails { get; set; }
    public string ID { get; set; }
    public string Name { get; set; }
    public bool ObtainOnStart { get; set; }
    public bool SeenByPlayer { get; set; }
    public bool ShowProgress { get; set; }
    public string Status { get; set; }
    public int ObtainedDateTime { get; set; }
    public int LastUpdatedDateTime { get; set; }
    public bool ShowInInspector { get; set; }
}

public class Reaction : Object
{
    public Reaction()
    {
    }

    public Reaction(System.IntPtr ptr) : base(ptr) { }

    public Reaction(string id, string characterToReactTo, List<Critera> critera, Double currentIteration, bool enabled, List<Event> events, string key, string name, bool showInInspector, string type, Double updateIteration, string value, string locationTargetOption)
    {
        Id = id;
        CharacterToReactTo = characterToReactTo;
        Critera = critera;
        CurrentIteration = currentIteration;
        Enabled = enabled;
        Events = events;
        Key = key;
        Name = name;
        ShowInInspector = showInInspector;
        Type = type;
        UpdateIteration = updateIteration;
        Value = value;
        LocationTargetOption = locationTargetOption;
    }

    public string Id { get; set; }
    public string CharacterToReactTo { get; set; }
    public List<Critera> Critera { get; set; }
    public Double CurrentIteration { get; set; }
    public bool Enabled { get; set; }
    public List<Event> Events { get; set; }
    public string Key { get; set; }
    public string Name { get; set; }
    public bool ShowInInspector { get; set; }
    public string Type { get; set; }
    public Double UpdateIteration { get; set; }
    public string Value { get; set; }
    public string LocationTargetOption { get; set; }
}

public class OnAcceptEvent : Object
{
    public OnAcceptEvent()
    {
    }

    public OnAcceptEvent(System.IntPtr ptr) : base(ptr) { }

    public OnAcceptEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, Double delay, Double originalDelay, Double startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria)
    {
        SortOrder2 = sortOrder2;
        Version = version;
        Id = id;
        Enabled = enabled;
        EventType = eventType;
        Character = character;
        Character2 = character2;
        Key = key;
        Option = option;
        Option2 = option2;
        Option3 = option3;
        Value = value;
        Value2 = value2;
        SortOrder = sortOrder;
        Delay = delay;
        OriginalDelay = originalDelay;
        StartDelayTime = startDelayTime;
        UseConditions = useConditions;
        DisplayInEditor = displayInEditor;
        Criteria = criteria;
    }

    public int SortOrder2 { get; set; }
    public string Version { get; set; }
    public string Id { get; set; }
    public bool Enabled { get; set; }
    public int EventType { get; set; }
    public string Character { get; set; }
    public string Character2 { get; set; }
    public string Key { get; set; }
    public int Option { get; set; }
    public int Option2 { get; set; }
    public int Option3 { get; set; }
    public string Value { get; set; }
    public string Value2 { get; set; }
    public int SortOrder { get; set; }
    public Double Delay { get; set; }
    public Double OriginalDelay { get; set; }
    public Double StartDelayTime { get; set; }
    public bool UseConditions { get; set; }
    public bool DisplayInEditor { get; set; }
    public List<Criterion> Criteria { get; set; }
}

public class StoryItem : Object
{
    public StoryItem()
    {
    }

    public StoryItem(System.IntPtr ptr) : base(ptr) { }

    public StoryItem(List<Critera> critera, string itemName, List<OnAcceptEvent> onAcceptEvents, List<Object> onRefuseEvents, bool displayInEditor)
    {
        Critera = critera;
        ItemName = itemName;
        OnAcceptEvents = onAcceptEvents;
        OnRefuseEvents = onRefuseEvents;
        DisplayInEditor = displayInEditor;
    }

    public List<Critera> Critera { get; set; }
    public string ItemName { get; set; }
    public List<OnAcceptEvent> OnAcceptEvents { get; set; }
    public List<Object> OnRefuseEvents { get; set; }
    public bool DisplayInEditor { get; set; }
}

public class CharacterStory : Object
{
    public CharacterStory()
    {
    }

    public CharacterStory(System.IntPtr ptr) : base(ptr) { }

    public CharacterStory(string characterName, string currentAspect, int dialogueID, List<Dialogue> dialogues, List<GlobalGoodbyeResponse> globalGoodbyeResponses, List<GlobalResponse> globalResponses, string housePartyVersion, List<BackgroundChatter> backgroundChatter, bool lockCharacterSelection, Personality personality, List<Quest> quests, List<Reaction> reactions, List<StoryItem> storyItems, List<Object> characterItemGroupInteractions, List<string> storyValues)
    {
        CharacterName = characterName;
        CurrentAspect = currentAspect;
        DialogueID = dialogueID;
        Dialogues = dialogues;
        GlobalGoodbyeResponses = globalGoodbyeResponses;
        GlobalResponses = globalResponses;
        HousePartyVersion = housePartyVersion;
        BackgroundChatter = backgroundChatter;
        LockCharacterSelection = lockCharacterSelection;
        Personality = personality;
        Quests = quests;
        Reactions = reactions;
        StoryItems = storyItems;
        CharacterItemGroupInteractions = characterItemGroupInteractions;
        StoryValues = storyValues;
    }

    public string CharacterName { get; set; }
    public string CurrentAspect { get; set; }
    public int DialogueID { get; set; }
    public List<Dialogue> Dialogues { get; set; }
    public List<GlobalGoodbyeResponse> GlobalGoodbyeResponses { get; set; }
    public List<GlobalResponse> GlobalResponses { get; set; }
    public string HousePartyVersion { get; set; }
    public List<BackgroundChatter> BackgroundChatter { get; set; }
    public bool LockCharacterSelection { get; set; }
    public Personality Personality { get; set; }
    public List<Quest> Quests { get; set; }
    public List<Reaction> Reactions { get; set; }
    public List<StoryItem> StoryItems { get; set; }
    public List<Object> CharacterItemGroupInteractions { get; set; }
    public List<string> StoryValues { get; set; }
}