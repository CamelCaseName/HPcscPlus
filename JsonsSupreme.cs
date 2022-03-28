using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Text;
using MelonLoader;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using Object = Il2CppSystem.Object;
using IntPtr = System.IntPtr;

namespace HPCSC
{
    sealed class JsonsSupreme
    {
        private static readonly Il2CppReferenceArray<Object> objectReferenceArray = new Il2CppReferenceArray<Object>(1);
        private static readonly string[] TypeNameList = {
            "Achievements",
            "AlternateTexts",
            "BackgroundChatter",
            "CloseEvents",
            "Critera",
            "Criteras",
            "Criteria",
            "CriteriaGroups",
            "CriteriaList",
            "CriteriaList2",
            "Criterion",
            "Dialogues",
            "Events",
            "ExtendedDetails",
            "GameStartEvents",
            "GlobalGoodbyeResponses",
            "GlobalResponses",
            "ItemActions",
            "ItemGroupBehaviors",
            "ItemGroups",
            "ItemOverrides",
            "OnAcceptEvents",
            "OnRefuseEvents",
            "OnSuccessEvents",
            "OnTakeActionEvents",
            "Personality",
            "PlayerReactions",
            "Quests",
            "Reactions",
            "ResponseCriteria",
            "ResponseEvents",
            "Responses",
            "StartEvents",
            "StoryItems",
            "UseWiths",
            "Values",
            "CharacterItemGroupInteractions",
            "ItemGroupBehaviors",
            "MainStory",
            "CharacterStory",
            "Object"
        };

        private readonly ConstructorInfo[] ConstructorList = new ConstructorInfo[TypeNameList.Length];
        private static readonly bool debug = true;
        private readonly Il2CppReferenceArray<MethodInfo>[] MethodInfoList = new Il2CppReferenceArray<MethodInfo>[TypeNameList.Length];
        private readonly char[] numbers = new char[] { '0', '1', '2', '3', '4', '4', '5', '6', '7', '8', '9', '.', 'n', 'u', 'l', 'f', 'a', 's', 'r', 't', 'e' };
        private readonly char[] seperators = new char[] { '{', '}', '[', ']', ',', ':' };
        private MethodInfo getList = new MethodInfo();
        private Type pType;
        private bool secondLayerCriteriaList = false;
        private MethodInfo setList = new MethodInfo();
        private Boolean system_Boolean = new Boolean();
        private Int32 system_Int32 = new Int32();
        private Object tokenObject = new Object();
        private Type[] TypeList;

        private static Il2CppReferenceArray<Object> CreateReferenceArray(Object @object)
        {
            objectReferenceArray[0] = @object;
            return objectReferenceArray;
        }

        public void Initialize()
        {
            ClassInjector.RegisterTypeInIl2Cpp<Criterion>();
            ClassInjector.RegisterTypeInIl2Cpp<Event>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemAction>();
            ClassInjector.RegisterTypeInIl2Cpp<UseWith>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemOverride>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemGroupBehavior>();
            ClassInjector.RegisterTypeInIl2Cpp<Achievement>();
            ClassInjector.RegisterTypeInIl2Cpp<CriteriaList>();
            ClassInjector.RegisterTypeInIl2Cpp<CriteriaGroup>();
            ClassInjector.RegisterTypeInIl2Cpp<ItemGroup>();
            ClassInjector.RegisterTypeInIl2Cpp<PlayerReaction>();
            ClassInjector.RegisterTypeInIl2Cpp<MainStory>();
            ClassInjector.RegisterTypeInIl2Cpp<AlternateText>();
            ClassInjector.RegisterTypeInIl2Cpp<Response>();
            ClassInjector.RegisterTypeInIl2Cpp<Event>();
            ClassInjector.RegisterTypeInIl2Cpp<Dialogue>();
            ClassInjector.RegisterTypeInIl2Cpp<GlobalGoodbyeResponse>();
            ClassInjector.RegisterTypeInIl2Cpp<GlobalResponse>();
            ClassInjector.RegisterTypeInIl2Cpp<BackgroundChatter>();
            ClassInjector.RegisterTypeInIl2Cpp<Valuee>();
            ClassInjector.RegisterTypeInIl2Cpp<Personality>();
            ClassInjector.RegisterTypeInIl2Cpp<ExtendedDetail>();
            ClassInjector.RegisterTypeInIl2Cpp<Quest>();
            ClassInjector.RegisterTypeInIl2Cpp<Reaction>();
            ClassInjector.RegisterTypeInIl2Cpp<StoryItem>();
            ClassInjector.RegisterTypeInIl2Cpp<CharacterItemGroupInteraction>();
            ClassInjector.RegisterTypeInIl2Cpp<CharacterStory>();

            TypeList = new Type[] {
                Il2CppType.Of<Achievement>(), //0
                Il2CppType.Of<AlternateText>(), //1
                Il2CppType.Of<BackgroundChatter>(),//2
                Il2CppType.Of<Event>(),//3
                Il2CppType.Of<Criterion>(),//4
                Il2CppType.Of<Criterion>(),//5
                Il2CppType.Of<Criterion>(),//6
                Il2CppType.Of<CriteriaGroup>(),//7
                Il2CppType.Of<CriteriaList>(),//8
                Il2CppType.Of<Criterion>(),//9
                Il2CppType.Of<Criterion>(),//10
                Il2CppType.Of<Dialogue>(),//11
                Il2CppType.Of<Event>(),//12
                Il2CppType.Of<ExtendedDetail>(),//13
                Il2CppType.Of<Event>(),//14
                Il2CppType.Of<GlobalGoodbyeResponse>(),//15
                Il2CppType.Of<GlobalResponse>(),//16
                Il2CppType.Of<ItemAction>(),//17
                Il2CppType.Of<ItemGroupBehavior>(),//18
                Il2CppType.Of<ItemGroup>(),//19
                Il2CppType.Of<ItemOverride>(),//20
                Il2CppType.Of<Event>(),//21
                Il2CppType.Of<Event>(),//22
                Il2CppType.Of<Event>(),//23
                Il2CppType.Of<Event>(),//24
                Il2CppType.Of<Personality>(),//25
                Il2CppType.Of<PlayerReaction>(),//26
                Il2CppType.Of<Quest>(),//27
                Il2CppType.Of<Reaction>(),//28
                Il2CppType.Of<Criterion>(),//29
                Il2CppType.Of<Event>(),//30
                Il2CppType.Of<Response>(),//31
                Il2CppType.Of<Event>(),//32
                Il2CppType.Of<StoryItem>(),//33
                Il2CppType.Of<UseWith>(),//34
                Il2CppType.Of<Valuee>(),//35
                Il2CppType.Of<CharacterItemGroupInteraction>(),//36
                Il2CppType.Of<ItemGroupBehavior>(),//37
                Il2CppType.Of<MainStory>(),//38
                Il2CppType.Of<CharacterStory>(),//39
                Il2CppType.Of<Object>()//40
            };

            for (int i = 0; i < ConstructorList.Length; i++)
            {
                ConstructorList[i] = TypeList[i].GetConstructor(Type.EmptyTypes);
                MethodInfoList[i] = TypeList[i].GetMethods();
            }
        }

        private Type FindTypeName(string typeToSearch)
        {
            LogWithLogicDepth(System.ConsoleColor.Gray, typeToSearch, -1);
            if (secondLayerCriteriaList)
            {
                typeToSearch += "2";
            }

            for (int i = 0; i < TypeNameList.Length; i++)
            {
                if (TypeNameList[i] == typeToSearch)
                {
                    LogWithLogicDepth(System.ConsoleColor.Gray, TypeList[i].Name, -1);
                    return TypeList[i];
                }
            }

            return Il2CppType.Of<Object>();
        }

        private bool IsInArray(char[] arr, char c)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (c == arr[i])
                {
                    return true;
                }
            }
            return false;
        }

        public static void LogWithLogicDepth(System.ConsoleColor color, string text, int logicDepth)
        {
            if (debug)
            {
                string builder = "#";
                /*
                for (int c = 0; c < logicDepth; c++)
                {
                    //indent for each call
                    builder += "    ";
                }*/
                builder += $"{logicDepth} ";
                builder += text;
                MelonLogger.Msg(color, builder);
            }
        }

        private Object CreateObject(Type type)
        {
            if (type == TypeList[3]) { return new Event(); }
            else if (type == Il2CppType.Of<List<Event>>()) { return new List<Event>(); }
            else if (type == TypeList[4]) { return new Criterion(); }
            else if (type == Il2CppType.Of<List<Criterion>>()) { return new List<Criterion>(); }
            else if (type == TypeList[17]) { return new ItemAction(); }
            else if (type == Il2CppType.Of<List<ItemAction>>()) { return new List<ItemAction>(); }
            else if (type == TypeList[34]) { return new UseWith(); }
            else if (type == Il2CppType.Of<List<UseWith>>()) { return new List<UseWith>(); }
            else if (type == TypeList[20]) { return new ItemOverride(); }
            else if (type == Il2CppType.Of<List<string>>()) { return new List<string>(); }
            else if (type == TypeList[18]) { return new ItemGroupBehavior(); }
            else if (type == TypeList[0]) { return new Achievement(); }
            else if (type == TypeList[8]) { return new CriteriaList(); }
            else if (type == Il2CppType.Of<List<CriteriaList>>()) { return new List<CriteriaList>(); }
            else if (type == TypeList[7]) { return new CriteriaGroup(); }
            else if (type == TypeList[19]) { return new ItemGroup(); }
            else if (type == TypeList[26]) { return new PlayerReaction(); }
            else if (type == TypeList[1]) { return new AlternateText(); }
            else if (type == TypeList[31]) { return new Response(); }
            else if (type == TypeList[11]) { return new Dialogue(); }
            else if (type == Il2CppType.Of<List<Response>>()) { return new List<Response>(); }
            else if (type == Il2CppType.Of<List<AlternateText>>()) { return new List<AlternateText>(); }
            else if (type == TypeList[15]) { return new GlobalGoodbyeResponse(); }
            else if (type == TypeList[16]) { return new GlobalResponse(); }
            else if (type == TypeList[2]) { return new BackgroundChatter(); }
            else if (type == TypeList[35]) { return new Valuee(); }
            else if (type == Il2CppType.Of<List<Valuee>>()) { return new List<Valuee>(); }
            else if (type == TypeList[25]) { return new Personality(); }
            else if (type == TypeList[13]) { return new ExtendedDetail(); }
            else if (type == Il2CppType.Of<List<ExtendedDetail>>()) { return new List<ExtendedDetail>(); }
            else if (type == TypeList[27]) { return new Quest(); }
            else if (type == TypeList[28]) { return new Reaction(); }
            else if (type == TypeList[33]) { return new StoryItem(); }
            else if (type == TypeList[36]) { return new CharacterItemGroupInteraction(); }
            else if (type == Il2CppType.Of<List<ItemOverride>>()) { return new List<ItemOverride>(); }
            else if (type == Il2CppType.Of<List<ItemGroupBehavior>>()) { return new List<ItemGroupBehavior>(); }
            else if (type == Il2CppType.Of<List<Achievement>>()) { return new List<Achievement>(); }
            else if (type == Il2CppType.Of<List<CriteriaGroup>>()) { return new List<CriteriaGroup>(); }
            else if (type == Il2CppType.Of<List<ItemGroup>>()) { return new List<ItemGroup>(); }
            else if (type == Il2CppType.Of<List<PlayerReaction>>()) { return new List<PlayerReaction>(); }
            else if (type == TypeList[38]) { return new MainStory(); }
            else if (type == Il2CppType.Of<List<Dialogue>>()) { return new List<Dialogue>(); }
            else if (type == Il2CppType.Of<List<GlobalGoodbyeResponse>>()) { return new List<GlobalGoodbyeResponse>(); }
            else if (type == Il2CppType.Of<List<GlobalResponse>>()) { return new List<GlobalResponse>(); }
            else if (type == Il2CppType.Of<List<BackgroundChatter>>()) { return new List<BackgroundChatter>(); }
            else if (type == Il2CppType.Of<List<Quest>>()) { return new List<Quest>(); }
            else if (type == Il2CppType.Of<List<Reaction>>()) { return new List<Reaction>(); }
            else if (type == Il2CppType.Of<List<StoryItem>>()) { return new List<StoryItem>(); }
            else if (type == Il2CppType.Of<List<CharacterItemGroupInteraction>>()) { return new List<CharacterItemGroupInteraction>(); }
            else if (type == TypeList[39]) { return new CharacterStory(); }
            else { MelonLogger.Msg($"Type '{type.Name}' not yet added to elseif"); return new Object(); }
        }

        //todo speed increase:
        // - replace list by queue, figure out how to cast objects to string in that case first
        // - change order of building, create all params first, then create object with all parameters to not call all set mothods one by one
        public T SetObjectValues<T>(Queue<string> tokens, Type type, Boolean isSecondLayerCriteriaList, int logicDepth = 0) where T : Object, new()
        {
            string lastToken = "";
            bool remove;
            string token = "";

            //iterate through tokens until we reach a start of an object, in the first case the mainstory
            while (token != "START_OBJECT")
            {
                //go to first start or remove token
                token = tokens.Dequeue();
                LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN0: {token}", logicDepth);
            }

            Object retObject = CreateObject(type);
            LogWithLogicDepth(System.ConsoleColor.DarkGray, $"Created object of type {type.Name}", logicDepth);

            //if we can create a new T, get all methods, then calling all set methods using reflection, filling them up with the objects we need
            Il2CppReferenceArray<MethodInfo> methodInfos = type.GetMethods();

            //go through tokens to call the method we need, weith the token after as argument.
            while (true)
            {
                remove = true;
                token = tokens.Dequeue();
                LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN1: {token}", logicDepth);

                //list starts
                if (token == "START_LIST")
                {
                    //create list, then go back to creating objects, then at end we stop and move on in the og object the list is part of
                    //get type of the list elements, name of them in lastToken

                    for (int i = 0; i < methodInfos.Count; i++)
                    {
                        if (methodInfos[i].Name == $"Get{lastToken}")
                        {
                            LogWithLogicDepth(System.ConsoleColor.White, $"got Get{lastToken}", logicDepth);
                            getList = methodInfos[i];
                        }
                        else if (methodInfos[i].Name == $"Set{lastToken}")
                        {
                            LogWithLogicDepth(System.ConsoleColor.White, $"got Set{lastToken}", logicDepth);
                            setList = methodInfos[i];
                        }
                    }

                    //get new tokens
                    token = tokens.Dequeue();

                    //get type from method signature
                    Type listType = getList.ReturnType;
                    Object list = CreateObject(listType);
                    MethodInfo listAdd = listType.GetMethod("Add");
                    LogWithLogicDepth(System.ConsoleColor.White, "created list", ++logicDepth);

                    //as long as we did not reach the end of the list, end it
                    while (token != "END_LIST")
                    {

                        LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN2: {token}", logicDepth);
                        Object objectToAdd;

                        if (!isSecondLayerCriteriaList.m_value && type == Il2CppType.Of<CriteriaList>())
                        {
                            isSecondLayerCriteriaList.m_value = true;
                            secondLayerCriteriaList = true;
                        }

                        if (token == "START_OBJECT")
                        {
                            //add object
                            objectToAdd = SetObjectValues<Object>(tokens, FindTypeName(lastToken), isSecondLayerCriteriaList, logicDepth + 1);
                        }
                        else
                        {
                            //add string
                            objectToAdd = token;
                            token = tokens.Dequeue();
                        }

                        if (isSecondLayerCriteriaList.m_value && type == Il2CppType.Of<CriteriaList>())
                        {
                            secondLayerCriteriaList = false;
                        }

                        LogWithLogicDepth(System.ConsoleColor.DarkCyan, $"adding object to list", logicDepth);
                        listAdd.Invoke(list, CreateReferenceArray(objectToAdd));
                        isSecondLayerCriteriaList.m_value = false;
                    }

                    //add list
                    LogWithLogicDepth(System.ConsoleColor.White, "adding list", --logicDepth);
                    setList.Invoke(retObject, CreateReferenceArray(list));
                }
                else if (token == "END_OBJECT")
                {
                    tokens.Dequeue();

                    LogWithLogicDepth(System.ConsoleColor.DarkGray, "End of object", logicDepth);

                    return retObject.Cast<T>();
                }
                //else field starts
                else
                {
                    for (int i = 0; i < methodInfos.Count; i++)
                    {
                        MethodInfo methodInfo = methodInfos[i];
                        if (methodInfo.Name == $"Set{token}")
                        {
                            lastToken = token;
                            token = tokens.Dequeue();
                            LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN3: {token}", logicDepth);

                            //get method parameter type so we can cast the string to the correct object
                            pType = methodInfo.GetParameterTypes()[0];

                            if (token != "START_LIST")
                            {
                                string lastTempToken = tokens.ToArray()[0];
                                if (lastTempToken != "START_LIST" && lastTempToken != "START_OBJECT")
                                {
                                    //try parsing if necessary, defaults to new constructor like values
                                    LogWithLogicDepth(System.ConsoleColor.DarkGray, $"Token is of a simple type: {token}", logicDepth);
                                    tokenObject = TryParseAll(pType, token);
                                }
                                else if (lastTempToken == "START_OBJECT")
                                {
                                    //try parsing if necessary, defaults to new constructor like values
                                    LogWithLogicDepth(System.ConsoleColor.DarkGray, $"token is of an object type: {token}", logicDepth);
                                    tokenObject = SetObjectValues<Object>(tokens, pType, isSecondLayerCriteriaList, logicDepth + 1);

                                    remove = false;
                                }
                            }
                            else
                            {
                                MelonLogger.Msg("..list starting..");
                                remove = false;
                                break;
                            }

                            LogWithLogicDepth(System.ConsoleColor.Green, $"Invoke successful! ({methodInfo.Name} with {token} as the parameter)", logicDepth);
                            methodInfo.Invoke(retObject, CreateReferenceArray(tokenObject));

                            break;
                        }
                    }
                }

                if (remove)
                {
                    lastToken = token;
                }
            }
        }

        public Queue<string> SplitJson(string tempS)
        {
            Queue<string> tokens = new Queue<string>(300000);

            bool inValueString = false;
            bool isEscaped = false;
            char c;
            //init stringbuilder with approximate buffer size for speed reasons (reduces resizing operations)
            StringBuilder stringBuilder = new StringBuilder(tempS.Length);

            for (int i = 0; i < tempS.Length; i++)
            {
                if (!isEscaped)
                {
                    c = tempS[i];

                    //entering string
                    if (inValueString)
                    {
                        //add char to builder if it is not escaped
                        if (c != '\\' && c != '"')
                        {
                            stringBuilder.Append(c);
                        }
                        else
                        {
                            if (c == '\\')
                            {
                                isEscaped = true;
                                stringBuilder.Append('\\');
                            }
                            else
                            {
                                inValueString = false;
                            }
                        }
                    }
                    else
                    {
                        if (c == '"')
                        {
                            inValueString = true;
                        }
                        else if (IsInArray(seperators, c))
                        {
                            //if we hit a seperator, add nonempty strings and clear string builder
                            if (stringBuilder.Length > 0) tokens.Enqueue(stringBuilder.ToString());
                            stringBuilder.Clear();

                            if (c == '[') tokens.Enqueue("START_LIST");
                            else if (c == ']') tokens.Enqueue("END_LIST");
                            else if (c == '{') tokens.Enqueue("START_OBJECT");
                            else if (c == '}') tokens.Enqueue("END_OBJECT");
                        }
                        else if (IsInArray(numbers, c))
                        {
                            //add char, in names and stuff
                            stringBuilder.Append(c);
                        }
                    }
                }
                else
                {
                    isEscaped = false;
                    //is escaped so add regardless
                    stringBuilder.Append(tempS[i]);
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
                        system_Boolean.m_value = bool.Parse(token);
                        return system_Boolean.BoxIl2CppObject();
                    case "System.Int32":
                        system_Int32.m_value = int.Parse(token, System.Globalization.NumberStyles.Integer);
                        return system_Int32.BoxIl2CppObject();
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
