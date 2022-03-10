using EekCharacterEngine.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerRuntimeLib;

//todo add singleton and unload chain to every class in here, lists also need to be cleared/disposed
namespace Project
{
    public class Criterion : Object
    {
        private Criterion instance;

        public Criterion() : base(ClassInjector.DerivedConstructorPointer<Criterion>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            instance = null;
        }

        public Criterion(System.IntPtr value) : base(value)
        {
        }

        public Criterion(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, string itemComparison, string itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option) : base(ClassInjector.DerivedConstructorPointer<Criterion>())
        {
            ClassInjector.DerivedConstructorBody(this);

            SetBoolValue(boolValue);
            SetCharacter(character);
            SetCharacter2(character2);
            SetCompareType(compareType);
            SetDialogueStatus(dialogueStatus);
            SetDisplayInEditor(displayInEditor);
            SetDoorOptions(doorOptions);
            SetEqualsValue(equalsValue);
            SetEquationValue(equationValue);
            SetValueFormula(valueFormula);
            SetItemComparison(itemComparison);
            SetItemFromItemGroupComparison(itemFromItemGroupComparison);
            SetKey(key);
            SetKey2(key2);
            SetOrder(order);
            SetPlayerInventoryOption(playerInventoryOption);
            SetPoseOption(poseOption);
            SetSocialStatus(socialStatus);
            SetValue(value);
            SetOption(option);
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

    public class OnTakeActionEvent : Object
    {
        private OnTakeActionEvent instance;

        public OnTakeActionEvent() : base(ClassInjector.DerivedConstructorPointer<OnTakeActionEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            instance = null;
        }

        public OnTakeActionEvent(System.IntPtr value) : base(value)
        {
        }

        public OnTakeActionEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<OnTakeActionEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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
        private ItemAction instance;

        public ItemAction() : base(ClassInjector.DerivedConstructorPointer<ItemAction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
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
            instance = null;
        }

        public ItemAction(System.IntPtr value) : base(value)
        {
        }

        public ItemAction(string actionName, List<Criterion> criteria, bool displayInEditor, List<OnTakeActionEvent> onTakeActionEvents) : base(ClassInjector.DerivedConstructorPointer<ItemAction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetActionName(actionName);
            SetCriteria(criteria);
            SetDisplayInEditor(displayInEditor);
            SetOnTakeActionEvents(onTakeActionEvents);
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

        private List<OnTakeActionEvent> onTakeActionEvents;

        public List<OnTakeActionEvent> GetOnTakeActionEvents()
        {
            return onTakeActionEvents;
        }

        public void SetOnTakeActionEvents(List<OnTakeActionEvent> value)
        {
            onTakeActionEvents = value;
        }
    }

    public class OnSuccessEvent : Object
    {
        private OnSuccessEvent instance;

        public OnSuccessEvent() : base(ClassInjector.DerivedConstructorPointer<OnSuccessEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            instance = null;
        }

        public OnSuccessEvent(System.IntPtr value) : base(value)
        {
        }

        public OnSuccessEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<OnSuccessEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class UseWith : Object
    {
        private UseWith instance;

        public UseWith() : base(ClassInjector.DerivedConstructorPointer<UseWith>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
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
            instance = null;
        }

        public UseWith(System.IntPtr value) : base(value)
        {
        }

        public UseWith(List<Criterion> criteria, string customCantDoThatMessage, bool displayInEditor, string itemName, List<OnSuccessEvent> onSuccessEvents) : base(ClassInjector.DerivedConstructorPointer<UseWith>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetCriteria(criteria);
            SetCustomCantDoThatMessage(customCantDoThatMessage);
            SetDisplayInEditor(displayInEditor);
            SetItemName(itemName);
            SetOnSuccessEvents(onSuccessEvents);
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

        private List<OnSuccessEvent> onSuccessEvents;

        public List<OnSuccessEvent> GetOnSuccessEvents()
        {
            return onSuccessEvents;
        }

        public void SetOnSuccessEvents(List<OnSuccessEvent> value)
        {
            onSuccessEvents = value;
        }
    }

    public class ItemOverride : Object
    {
        private ItemOverride instance;

        public ItemOverride() : base(ClassInjector.DerivedConstructorPointer<ItemOverride>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
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
            instance = null;
        }

        public ItemOverride(System.IntPtr value) : base(value)
        {
        }

        public ItemOverride(string id, bool displayInEditor, string displayName, List<ItemAction> itemActions, string itemName, List<UseWith> useWiths, bool useDefaultRadialOptions) : base(ClassInjector.DerivedConstructorPointer<ItemOverride>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetDisplayInEditor(displayInEditor);
            SetDisplayName(displayName);
            SetItemActions(itemActions);
            SetItemName(itemName);
            SetUseWiths(useWiths);
            SetUseDefaultRadialOptions(useDefaultRadialOptions);
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
        private ItemGroupBehavior instance;

        public ItemGroupBehavior() : base(ClassInjector.DerivedConstructorPointer<ItemGroupBehavior>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in itemActions)
            {
                item.Unload();
            }
            itemActions = null;
            useWiths = null;
            instance = null;
        }

        public ItemGroupBehavior(System.IntPtr value) : base(value)
        {
        }

        public ItemGroupBehavior(string id, string name, string groupName, bool displayInEditor, List<ItemAction> itemActions, List<string> useWiths) : base(ClassInjector.DerivedConstructorPointer<ItemGroupBehavior>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetName(name);
            SetGroupName(groupName);
            SetDisplayInEditor(displayInEditor);
            SetItemActions(itemActions);
            SetUseWiths(useWiths);
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
        private Achievement instance;

        public Achievement() : base(ClassInjector.DerivedConstructorPointer<Achievement>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            instance = null;
        }

        public Achievement(System.IntPtr value) : base(value)
        {
        }

        public Achievement(string description, string id, string image, string name, bool showInEditor, string steamName) : base(ClassInjector.DerivedConstructorPointer<Achievement>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetDescription(description);
            SetId(id);
            SetImage(image);
            SetName(name);
            SetShowInEditor(showInEditor);
            SetSteamName(steamName);
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

    public class CriteriaList2 : Object
    {
        private CriteriaList2 instance;

        public CriteriaList2() : base(ClassInjector.DerivedConstructorPointer<CriteriaList2>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            instance = null;
        }

        public CriteriaList2(System.IntPtr value) : base(value)
        {
        }

        public CriteriaList2(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, string itemComparison, string itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option) : base(ClassInjector.DerivedConstructorPointer<CriteriaList2>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetBoolValue(boolValue);
            SetCharacter(character);
            SetCharacter2(character2);
            SetCompareType(compareType);
            SetDialogueStatus(dialogueStatus);
            SetDisplayInEditor(displayInEditor);
            SetDoorOptions(doorOptions);
            SetEqualsValue(equalsValue);
            SetEquationValue(equationValue);
            SetValueFormula(valueFormula);
            SetItemComparison(itemComparison);
            SetItemFromItemGroupComparison(itemFromItemGroupComparison);
            SetKey(key);
            SetKey2(key2);
            SetOrder(order);
            SetPlayerInventoryOption(playerInventoryOption);
            SetPoseOption(poseOption);
            SetSocialStatus(socialStatus);
            SetValue(value);
            SetOption(option);
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

    public class CriteriaList1 : Object
    {
        private CriteriaList1 instance;

        public CriteriaList1() : base(ClassInjector.DerivedConstructorPointer<CriteriaList1>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in criteriaList)
            {
                item.Unload();
            }
            criteriaList = null;
            instance = null;
        }

        public CriteriaList1(System.IntPtr value) : base(value)
        {
        }

        public CriteriaList1(List<CriteriaList2> criteriaList) : base(ClassInjector.DerivedConstructorPointer<CriteriaList1>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetCriteriaList(criteriaList);
        }

        private List<CriteriaList2> criteriaList;

        public List<CriteriaList2> GetCriteriaList()
        {
            return criteriaList;
        }

        public void SetCriteriaList(List<CriteriaList2> value)
        {
            criteriaList = value;
        }
    }

    public class CriteriaGroup : Object
    {
        private CriteriaGroup instance;

        public CriteriaGroup() : base(ClassInjector.DerivedConstructorPointer<CriteriaGroup>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in criteriaList)
            {
                item.Unload();
            }
            criteriaList = null;
            instance = null;
        }

        public CriteriaGroup(System.IntPtr value) : base(value)
        {
        }

        public CriteriaGroup(string id, string name, bool displayInEditor, string passCondition, List<CriteriaList1> criteriaList) : base(ClassInjector.DerivedConstructorPointer<CriteriaGroup>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetName(name);
            SetDisplayInEditor(displayInEditor);
            SetPassCondition(passCondition);
            SetCriteriaList(criteriaList);
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

        private List<CriteriaList1> criteriaList;

        public List<CriteriaList1> GetCriteriaList()
        {
            return criteriaList;
        }

        public void SetCriteriaList(List<CriteriaList1> value)
        {
            criteriaList = value;
        }
    }

    public class ItemGroup : Object
    {
        private ItemGroup instance;

        public ItemGroup() : base(ClassInjector.DerivedConstructorPointer<ItemGroup>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            itemsInGroup = null;
            instance = null;
        }

        public ItemGroup(System.IntPtr value) : base(value)
        {
        }

        public ItemGroup(string id, string name, bool displayInEditor, List<string> itemsInGroup) : base(ClassInjector.DerivedConstructorPointer<ItemGroup>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetName(name);
            SetDisplayInEditor(displayInEditor);
            SetItemsInGroup(itemsInGroup);
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

    public class GameStartEvent : Object
    {
        private GameStartEvent instance;

        public GameStartEvent() : base(ClassInjector.DerivedConstructorPointer<GameStartEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            instance = null;
        }

        public GameStartEvent(System.IntPtr value) : base(value)
        {
        }

        public GameStartEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<GameStartEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class Critera : Object
    {
        private Critera instance;

        public Critera() : base(ClassInjector.DerivedConstructorPointer<Critera>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            instance = null;
        }

        public Critera(System.IntPtr value) : base(value)
        {
        }

        public Critera(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, string itemComparison, string itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option) : base(ClassInjector.DerivedConstructorPointer<Critera>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetBoolValue(boolValue);
            SetCharacter(character);
            SetCharacter2(character2);
            SetCompareType(compareType);
            SetDialogueStatus(dialogueStatus);
            SetDisplayInEditor(displayInEditor);
            SetDoorOptions(doorOptions);
            SetEqualsValue(equalsValue);
            SetEquationValue(equationValue);
            SetValueFormula(valueFormula);
            SetItemComparison(itemComparison);
            SetItemFromItemGroupComparison(itemFromItemGroupComparison);
            SetKey(key);
            SetKey2(key2);
            SetOrder(order);
            SetPlayerInventoryOption(playerInventoryOption);
            SetPoseOption(poseOption);
            SetSocialStatus(socialStatus);
            SetValue(value);
            SetOption(option);
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
        private Event instance;

        public Event() : base(ClassInjector.DerivedConstructorPointer<Event>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            foreach (var item in criteria)
            {
                item.Unload();
            }
            criteria = null;
            instance = null;
        }

        public Event(System.IntPtr value) : base(value)
        {
        }

        public Event(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<Event>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class PlayerReaction : Object
    {
        private PlayerReaction instance;

        public PlayerReaction() : base(ClassInjector.DerivedConstructorPointer<PlayerReaction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
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
            instance = null;
        }

        public PlayerReaction(System.IntPtr value) : base(value)
        {
        }

        public PlayerReaction(string id, string characterToReactTo, List<Critera> critera, string currentIteration, bool enabled, List<Event> events, string key, string name, bool showInInspector, string type, string updateIteration, string value, string locationTargetOption) : base(ClassInjector.DerivedConstructorPointer<PlayerReaction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetCharacterToReactTo(characterToReactTo);
            SetCritera(critera);
            SetCurrentIteration(currentIteration);
            SetEnabled(enabled);
            SetEvents(events);
            SetKey(key);
            SetName(name);
            SetShowInInspector(showInInspector);
            SetType(type);
            SetUpdateIteration(updateIteration);
            SetValue(value);
            SetLocationTargetOption(locationTargetOption);
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

        private List<Critera> critera;

        public List<Critera> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Critera> value)
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
        static MainStory instance;

        public MainStory() : base(ClassInjector.DerivedConstructorPointer<MainStory>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
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
            instance = null;
        }

        public MainStory(System.IntPtr value) : base(value)
        {
        }

        public MainStory(string housePartyVersion, List<ItemOverride> itemOverrides, List<ItemGroupBehavior> itemGroupBehaviors, List<Achievement> achievements, List<string> playerValues, List<CriteriaGroup> criteriaGroups, List<ItemGroup> itemGroups, List<GameStartEvent> gameStartEvents, List<PlayerReaction> playerReactions) : base(ClassInjector.DerivedConstructorPointer<MainStory>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetHousePartyVersion(housePartyVersion);
            SetItemOverrides(itemOverrides);
            SetItemGroupBehaviors(itemGroupBehaviors);
            SetAchievements(achievements);
            SetPlayerValues(playerValues);
            SetCriteriaGroups(criteriaGroups);
            SetItemGroups(itemGroups);
            SetGameStartEvents(gameStartEvents);
            SetPlayerReactions(playerReactions);
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

        private List<GameStartEvent> gameStartEvents;

        public List<GameStartEvent> GetGameStartEvents()
        {
            return gameStartEvents;
        }

        public void SetGameStartEvents(List<GameStartEvent> value)
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

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class AlternateText : Object
    {

        public AlternateText() : base(ClassInjector.DerivedConstructorPointer<AlternateText>()) => ClassInjector.DerivedConstructorBody(this);

        public AlternateText(System.IntPtr value) : base(value)
        {
        }

        public AlternateText(List<Critera> critera, int order, bool show, string text) : base(ClassInjector.DerivedConstructorPointer<AlternateText>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetCritera(critera);
            SetOrder(order);
            SetShow(show);
            SetText(text);
        }

        private List<Critera> critera;

        public List<Critera> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Critera> value)
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

    public class CloseEvent : Object
    {

        public CloseEvent() : base(ClassInjector.DerivedConstructorPointer<CloseEvent>()) => ClassInjector.DerivedConstructorBody(this);

        public CloseEvent(System.IntPtr value) : base(value)
        {
        }

        public CloseEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<CloseEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class ResponseCriteria : Object
    {

        public ResponseCriteria() : base(ClassInjector.DerivedConstructorPointer<ResponseCriteria>()) => ClassInjector.DerivedConstructorBody(this);

        public ResponseCriteria(System.IntPtr value) : base(value)
        {
        }

        public ResponseCriteria(string boolValue, string character, string character2, string compareType, string dialogueStatus, bool displayInEditor, string doorOptions, string equalsValue, string equationValue, string valueFormula, string itemComparison, string itemFromItemGroupComparison, string key, string key2, int order, string playerInventoryOption, string poseOption, string socialStatus, string value, int option) : base(ClassInjector.DerivedConstructorPointer<ResponseCriteria>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetBoolValue(boolValue);
            SetCharacter(character);
            SetCharacter2(character2);
            SetCompareType(compareType);
            SetDialogueStatus(dialogueStatus);
            SetDisplayInEditor(displayInEditor);
            SetDoorOptions(doorOptions);
            SetEqualsValue(equalsValue);
            SetEquationValue(equationValue);
            SetValueFormula(valueFormula);
            SetItemComparison(itemComparison);
            SetItemFromItemGroupComparison(itemFromItemGroupComparison);
            SetKey(key);
            SetKey2(key2);
            SetOrder(order);
            SetPlayerInventoryOption(playerInventoryOption);
            SetPoseOption(poseOption);
            SetSocialStatus(socialStatus);
            SetValue(value);
            SetOption(option);
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

    public class ResponseEvent : Object
    {

        public ResponseEvent() : base(ClassInjector.DerivedConstructorPointer<ResponseEvent>()) => ClassInjector.DerivedConstructorBody(this);

        public ResponseEvent(System.IntPtr value) : base(value)
        {
        }

        public ResponseEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<ResponseEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class Response : Object
    {

        public Response() : base(ClassInjector.DerivedConstructorPointer<Response>()) => ClassInjector.DerivedConstructorBody(this);

        public Response(System.IntPtr value) : base(value)
        {
        }

        public Response(bool selected, string id, bool alwaysDisplay, int next, int order, List<ResponseCriteria> responseCriteria, List<ResponseEvent> responseEvents, bool show, bool showResponseCriteria, bool showResponseEvents, bool testingCriteraOverride, string text, string characterName, int chatterId, bool showInInspector) : base(ClassInjector.DerivedConstructorPointer<Response>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSelected(selected);
            SetId(id);
            SetAlwaysDisplay(alwaysDisplay);
            SetNext(next);
            SetOrder(order);
            SetResponseCriteria(responseCriteria);
            SetResponseEvents(responseEvents);
            SetShow(show);
            SetShowResponseCriteria(showResponseCriteria);
            SetShowResponseEvents(showResponseEvents);
            SetTestingCriteraOverride(testingCriteraOverride);
            SetText(text);
            SetCharacterName(characterName);
            SetChatterId(chatterId);
            SetShowInInspector(showInInspector);
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

        private List<ResponseCriteria> responseCriteria;

        public List<ResponseCriteria> GetResponseCriteria()
        {
            return responseCriteria;
        }

        public void SetResponseCriteria(List<ResponseCriteria> value)
        {
            responseCriteria = value;
        }

        private List<ResponseEvent> responseEvents;

        public List<ResponseEvent> GetResponseEvents()
        {
            return responseEvents;
        }

        public void SetResponseEvents(List<ResponseEvent> value)
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

    public class StartEvent : Object
    {

        public StartEvent() : base(ClassInjector.DerivedConstructorPointer<StartEvent>()) => ClassInjector.DerivedConstructorBody(this);

        public StartEvent(System.IntPtr value) : base(value)
        {
        }

        public StartEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<StartEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class Dialogue : Object
    {
        public Dialogue() : base(ClassInjector.DerivedConstructorPointer<Dialogue>()) => ClassInjector.DerivedConstructorBody(this);

        public Dialogue(System.IntPtr value) : base(value)
        {
        }

        public Dialogue(bool shown, List<AlternateText> alternateTexts, List<CloseEvent> closeEvents, int iD, bool important, List<Response> responses, bool showAcceptedItems, bool showAlternateTexts, bool showCloseValueAdjustments, bool showCritera, bool showGlobalGoodByeResponses, bool playVoice, int voiceID, bool showGlobalResponses, bool doesNotCountAsMet, bool showResponses, bool showStartValueAdjustments, string speakingToCharacterName, List<StartEvent> startEvents, string text) : base(ClassInjector.DerivedConstructorPointer<Dialogue>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetShown(shown);
            SetAlternateTexts(alternateTexts);
            SetCloseEvents(closeEvents);
            SetID(iD);
            SetImportant(important);
            SetResponses(responses);
            SetShowAcceptedItems(showAcceptedItems);
            SetShowAlternateTexts(showAlternateTexts);
            SetShowCloseValueAdjustments(showCloseValueAdjustments);
            SetShowCritera(showCritera);
            SetShowGlobalGoodByeResponses(showGlobalGoodByeResponses);
            SetPlayVoice(playVoice);
            SetVoiceID(voiceID);
            SetShowGlobalResponses(showGlobalResponses);
            SetDoesNotCountAsMet(doesNotCountAsMet);
            SetShowResponses(showResponses);
            SetShowStartValueAdjustments(showStartValueAdjustments);
            SetSpeakingToCharacterName(speakingToCharacterName);
            SetStartEvents(startEvents);
            SetText(text);
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

        private List<CloseEvent> closeEvents;

        public List<CloseEvent> GetCloseEvents()
        {
            return closeEvents;
        }

        public void SetCloseEvents(List<CloseEvent> value)
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

        private List<StartEvent> startEvents;

        public List<StartEvent> GetStartEvents()
        {
            return startEvents;
        }

        public void SetStartEvents(List<StartEvent> value)
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
        public GlobalGoodbyeResponse() : base(ClassInjector.DerivedConstructorPointer<GlobalGoodbyeResponse>()) => ClassInjector.DerivedConstructorBody(this);

        public GlobalGoodbyeResponse(System.IntPtr value) : base(value)
        {
        }

        public GlobalGoodbyeResponse(bool selected, string id, bool alwaysDisplay, int next, int order, List<ResponseCriteria> responseCriteria, List<ResponseEvent> responseEvents, bool show, bool showResponseCriteria, bool showResponseEvents, bool testingCriteraOverride, string text) : base(ClassInjector.DerivedConstructorPointer<GlobalGoodbyeResponse>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSelected(selected);
            SetId(id);
            SetAlwaysDisplay(alwaysDisplay);
            SetNext(next);
            SetOrder(order);
            SetResponseCriteria(responseCriteria);
            SetResponseEvents(responseEvents);
            SetShow(show);
            SetShowResponseCriteria(showResponseCriteria);
            SetShowResponseEvents(showResponseEvents);
            SetTestingCriteraOverride(testingCriteraOverride);
            SetText(text);
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

        private List<ResponseCriteria> responseCriteria;

        public List<ResponseCriteria> GetResponseCriteria()
        {
            return responseCriteria;
        }

        public void SetResponseCriteria(List<ResponseCriteria> value)
        {
            responseCriteria = value;
        }

        private List<ResponseEvent> responseEvents;

        public List<ResponseEvent> GetResponseEvents()
        {
            return responseEvents;
        }

        public void SetResponseEvents(List<ResponseEvent> value)
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
        public GlobalResponse() : base(ClassInjector.DerivedConstructorPointer<GlobalResponse>()) => ClassInjector.DerivedConstructorBody(this);

        public GlobalResponse(System.IntPtr value) : base(value)
        {
        }

        public GlobalResponse(bool selected, string id, bool alwaysDisplay, int next, int order, List<ResponseCriteria> responseCriteria, List<ResponseEvent> responseEvents, bool show, bool showResponseCriteria, bool showResponseEvents, bool testingCriteraOverride, string text) : base(ClassInjector.DerivedConstructorPointer<GlobalResponse>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSelected(selected);
            SetId(id);
            SetAlwaysDisplay(alwaysDisplay);
            SetNext(next);
            SetOrder(order);
            SetResponseCriteria(responseCriteria);
            SetResponseEvents(responseEvents);
            SetShow(show);
            SetShowResponseCriteria(showResponseCriteria);
            SetShowResponseEvents(showResponseEvents);
            SetTestingCriteraOverride(testingCriteraOverride);
            SetText(text);
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

        private List<ResponseCriteria> responseCriteria;

        public List<ResponseCriteria> GetResponseCriteria()
        {
            return responseCriteria;
        }

        public void SetResponseCriteria(List<ResponseCriteria> value)
        {
            responseCriteria = value;
        }

        private List<ResponseEvent> responseEvents;

        public List<ResponseEvent> GetResponseEvents()
        {
            return responseEvents;
        }

        public void SetResponseEvents(List<ResponseEvent> value)
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
        public BackgroundChatter() : base(ClassInjector.DerivedConstructorPointer<BackgroundChatter>()) => ClassInjector.DerivedConstructorBody(this);

        public BackgroundChatter(System.IntPtr value) : base(value)
        {
        }

        public BackgroundChatter(int id, string text, List<Critera> critera, bool isConversationStarter, bool showInInspector, string speakingTo, bool overrideCombatRestriction, List<StartEvent> startEvents, List<Response> responses, string pairedEmote, string defaultImportance) : base(ClassInjector.DerivedConstructorPointer<BackgroundChatter>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetText(text);
            SetCritera(critera);
            SetIsConversationStarter(isConversationStarter);
            SetShowInInspector(showInInspector);
            SetSpeakingTo(speakingTo);
            SetOverrideCombatRestriction(overrideCombatRestriction);
            SetStartEvents(startEvents);
            SetResponses(responses);
            SetPairedEmote(pairedEmote);
            SetDefaultImportance(defaultImportance);
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

        private List<Critera> critera;

        public List<Critera> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Critera> value)
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

        private List<StartEvent> startEvents;

        public List<StartEvent> GetStartEvents()
        {
            return startEvents;
        }

        public void SetStartEvents(List<StartEvent> value)
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
        public Valuee() : base(ClassInjector.DerivedConstructorPointer<Valuee>()) => ClassInjector.DerivedConstructorBody(this);

        public Valuee(System.IntPtr value) : base(value)
        {
        }

        public Valuee(string type, int value) : base(ClassInjector.DerivedConstructorPointer<Valuee>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetType(type);
            SetValue(value);
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
        public Personality() : base(ClassInjector.DerivedConstructorPointer<Personality>()) => ClassInjector.DerivedConstructorBody(this);

        public Personality(System.IntPtr value) : base(value)
        {
        }

        public Personality(List<Valuee> values) : base(ClassInjector.DerivedConstructorPointer<Personality>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetValues(values);
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
        public ExtendedDetail() : base(ClassInjector.DerivedConstructorPointer<ExtendedDetail>()) => ClassInjector.DerivedConstructorBody(this);

        public ExtendedDetail(System.IntPtr value) : base(value)
        {
        }

        public ExtendedDetail(int value, string details) : base(ClassInjector.DerivedConstructorPointer<ExtendedDetail>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetValue(value);
            SetDetails(details);
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
        public Quest() : base(ClassInjector.DerivedConstructorPointer<Quest>()) => ClassInjector.DerivedConstructorBody(this);

        public Quest(System.IntPtr value) : base(value)
        {
        }

        public Quest(string characterName, int completeAt, int currentValue, string details, string completedDetails, string failedDetails, List<ExtendedDetail> extendedDetails, string iD, string name, bool obtainOnStart, bool seenByPlayer, bool showProgress, string status, int obtainedDateTime, int lastUpdatedDateTime, bool showInInspector) : base(ClassInjector.DerivedConstructorPointer<Quest>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetCharacterName(characterName);
            SetCompleteAt(completeAt);
            SetCurrentValue(currentValue);
            SetDetails(details);
            SetCompletedDetails(completedDetails);
            SetFailedDetails(failedDetails);
            SetExtendedDetails(extendedDetails);
            SetID(iD);
            SetName(name);
            SetObtainOnStart(obtainOnStart);
            SetSeenByPlayer(seenByPlayer);
            SetShowProgress(showProgress);
            SetStatus(status);
            SetObtainedDateTime(obtainedDateTime);
            SetLastUpdatedDateTime(lastUpdatedDateTime);
            SetShowInInspector(showInInspector);
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
        public Reaction() : base(ClassInjector.DerivedConstructorPointer<Reaction>()) => ClassInjector.DerivedConstructorBody(this);

        public Reaction(System.IntPtr value) : base(value)
        {
        }

        public Reaction(string id, string characterToReactTo, List<Critera> critera, string currentIteration, bool enabled, List<Event> events, string key, string name, bool showInInspector, string type, string updateIteration, string value, string locationTargetOption) : base(ClassInjector.DerivedConstructorPointer<Reaction>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetId(id);
            SetCharacterToReactTo(characterToReactTo);
            SetCritera(critera);
            SetCurrentIteration(currentIteration);
            SetEnabled(enabled);
            SetEvents(events);
            SetKey(key);
            SetName(name);
            SetShowInInspector(showInInspector);
            SetType(type);
            SetUpdateIteration(updateIteration);
            SetValue(value);
            SetLocationTargetOption(locationTargetOption);
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

        private List<Critera> critera;

        public List<Critera> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Critera> value)
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

    public class OnAcceptEvent : Object
    {
        public OnAcceptEvent() : base(ClassInjector.DerivedConstructorPointer<OnAcceptEvent>()) => ClassInjector.DerivedConstructorBody(this);

        public OnAcceptEvent(System.IntPtr value) : base(value)
        {
        }

        public OnAcceptEvent(int sortOrder2, string version, string id, bool enabled, int eventType, string character, string character2, string key, int option, int option2, int option3, string value, string value2, int sortOrder, string delay, string originalDelay, string startDelayTime, bool useConditions, bool displayInEditor, List<Criterion> criteria) : base(ClassInjector.DerivedConstructorPointer<OnAcceptEvent>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetSortOrder2(sortOrder2);
            SetVersion(version);
            SetId(id);
            SetEnabled(enabled);
            SetEventType(eventType);
            SetCharacter(character);
            SetCharacter2(character2);
            SetKey(key);
            SetOption(option);
            SetOption2(option2);
            SetOption3(option3);
            SetValue(value);
            SetValue2(value2);
            SetSortOrder(sortOrder);
            SetDelay(delay);
            SetOriginalDelay(originalDelay);
            SetStartDelayTime(startDelayTime);
            SetUseConditions(useConditions);
            SetDisplayInEditor(displayInEditor);
            SetCriteria(criteria);
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

    public class StoryItem : Object
    {
        public StoryItem() : base(ClassInjector.DerivedConstructorPointer<StoryItem>()) => ClassInjector.DerivedConstructorBody(this);

        public StoryItem(System.IntPtr value) : base(value)
        {
        }

        public StoryItem(List<Critera> critera, string itemName, List<OnAcceptEvent> onAcceptEvents, List<Object> onRefuseEvents, bool displayInEditor) : base(ClassInjector.DerivedConstructorPointer<StoryItem>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetCritera(critera);
            SetItemName(itemName);
            SetOnAcceptEvents(onAcceptEvents);
            SetOnRefuseEvents(onRefuseEvents);
            SetDisplayInEditor(displayInEditor);
        }

        private List<Critera> critera;

        public List<Critera> GetCritera()
        {
            return critera;
        }

        public void SetCritera(List<Critera> value)
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

        private List<OnAcceptEvent> onAcceptEvents;

        public List<OnAcceptEvent> GetOnAcceptEvents()
        {
            return onAcceptEvents;
        }

        public void SetOnAcceptEvents(List<OnAcceptEvent> value)
        {
            onAcceptEvents = value;
        }

        private List<Object> onRefuseEvents;

        public List<Object> GetOnRefuseEvents()
        {
            return onRefuseEvents;
        }

        public void SetOnRefuseEvents(List<Object> value)
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

    public class CharacterStory : Object
    {
        private CharacterStory instance;

        public CharacterStory() : base(ClassInjector.DerivedConstructorPointer<CharacterStory>())
        {
            ClassInjector.DerivedConstructorBody(this);
            instance = this;
        }

        public void Unload()
        {
            instance = null;
        }

        public CharacterStory(System.IntPtr value) : base(value)
        {
        }

        public CharacterStory(string characterName, string currentAspect, int dialogueID, List<Dialogue> dialogues, List<GlobalGoodbyeResponse> globalGoodbyeResponses, List<GlobalResponse> globalResponses, string housePartyVersion, List<BackgroundChatter> backgroundChatter, bool lockCharacterSelection, Personality personality, List<Quest> quests, List<Reaction> reactions, List<StoryItem> storyItems, List<Object> characterItemGroupInteractions, List<string> storyValues) : base(ClassInjector.DerivedConstructorPointer<CharacterStory>())
        {
            ClassInjector.DerivedConstructorBody(this);
            SetCharacterName(characterName);
            SetCurrentAspect(currentAspect);
            SetDialogueID(dialogueID);
            SetDialogues(dialogues);
            SetGlobalGoodbyeResponses(globalGoodbyeResponses);
            SetGlobalResponses(globalResponses);
            SetHousePartyVersion(housePartyVersion);
            SetBackgroundChatter(backgroundChatter);
            SetLockCharacterSelection(lockCharacterSelection);
            SetPersonality(personality);
            SetQuests(quests);
            SetReactions(reactions);
            SetStoryItems(storyItems);
            SetCharacterItemGroupInteractions(characterItemGroupInteractions);
            SetStoryValues(storyValues);
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

        private List<Object> characterItemGroupInteractions;

        public List<Object> GetCharacterItemGroupInteractions()
        {
            return characterItemGroupInteractions;
        }

        public void SetCharacterItemGroupInteractions(List<Object> value)
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
