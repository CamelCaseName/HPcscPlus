using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using MelonLoader;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using Object = Il2CppSystem.Object;

namespace HPCSC
{
    sealed class JsonsSupreme
    {
        public static readonly string END_LIST = "END_LIST";
        public static readonly string END_OBJECT = "END_OBJECT";
        public static readonly string NULL = "NULL";
        public static readonly string START_LIST = "START_LIST";
        public static readonly string START_OBJECT = "START_OBJECT";
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

        private readonly List<ConstructorInfo> AfterStartConstructorList = new List<ConstructorInfo>();
        private readonly List<Type> AfterStartTypeList = new List<Type>();
        private readonly ConstructorInfo[] ConstructorList = new ConstructorInfo[TypeNameList.Length];
        private readonly bool debug = true;
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
                Il2CppType.Of<Achievement>(),
                Il2CppType.Of<AlternateText>(),
                Il2CppType.Of<BackgroundChatter>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<CriteriaGroup>(),
                Il2CppType.Of<CriteriaList>(),
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<Dialogue>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<ExtendedDetail>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<GlobalGoodbyeResponse>(),
                Il2CppType.Of<GlobalResponse>(),
                Il2CppType.Of<ItemAction>(),
                Il2CppType.Of<ItemGroupBehavior>(),
                Il2CppType.Of<ItemGroup>(),
                Il2CppType.Of<ItemOverride>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<PlayerReaction>(),
                Il2CppType.Of<Quest>(),
                Il2CppType.Of<Reaction>(),
                Il2CppType.Of<Criterion>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<Response>(),
                Il2CppType.Of<Event>(),
                Il2CppType.Of<StoryItem>(),
                Il2CppType.Of<UseWith>(),
                Il2CppType.Of<Valuee>(),
                Il2CppType.Of<CharacterItemGroupInteraction>(),
                Il2CppType.Of<ItemGroupBehavior>(),
                Il2CppType.Of<MainStory>(),
                Il2CppType.Of<CharacterStory>(),
                Il2CppType.Of<Object>()
            };

            for (int i = 0; i < ConstructorList.Length; i++)
            {
                ConstructorList[i] = TypeList[i].GetConstructor(Type.EmptyTypes);
                MethodInfoList[i] = TypeList[i].GetMethods();
            }
        }

        private Object CreateObject(Type type)
        {
            for (int i = 0; i < TypeList.Length; i++)
            {
                if (TypeList[i] == type)
                {
                    MelonLogger.Msg("type seen at compile time");
                    return ConstructorList[i].Invoke(new Il2CppReferenceArray<Object>(ConstructorList[i].GetParametersCount()));
                }
            }
            //not in save types, need to get it dynamic (check if we have it first)
            for (int i = 0; i < AfterStartTypeList.Count; i++)
            {
                if (AfterStartTypeList[i] == type)
                {
                    MelonLogger.Msg("type seen before at runtime");
                    return AfterStartConstructorList[i].Invoke(new Il2CppReferenceArray<Object>(ConstructorList[i].GetParametersCount()));
                }
            }
            AfterStartTypeList.Add(type);
            AfterStartConstructorList.Add(type.GetConstructor(Type.EmptyTypes));

            MelonLogger.Msg("type not seen before at runtime");
            return AfterStartConstructorList[AfterStartConstructorList.Count - 1].Invoke(new Il2CppReferenceArray<Object>(AfterStartConstructorList[AfterStartConstructorList.Count - 1].GetParametersCount()));
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

        public void LogWithLogicDepth(System.ConsoleColor color, string text, int logicDepth)
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

        /*
        private delegate Object ConstructorDelegate();

        private ConstructorDelegate ObjectCreator(Type type, ConstructorInfo Ctor)
        {
            string methodName = $"{type.Name}Ctor";
            System.Reflection.Emit.DynamicMethod dynamicMethod = new System.Reflection.Emit.DynamicMethod(methodName, type.GetType(), new System.Type[0], typeof(System.Activator));
            System.Reflection.Emit.ILGenerator ilgen = dynamicMethod.GetILGenerator();
            System.Reflection.ConstructorInfo ctor = (System.Reflection.ConstructorInfo)Ctor;
            ilgen.Emit(System.Reflection.Emit.OpCodes.Newobj, ctor);
            ilgen.Emit(System.Reflection.Emit.OpCodes.Ret);

            ConstructorDelegate creator = (ConstructorDelegate)dynamicMethod.CreateDelegate(DelegateSupport.)
        }
        */

        //todo speed increase:
        // - replace list by queue, figure out how to cast objects to string in that case first
        // - change order of building, create all params first, then create object with all parameters to not call all set mothods one by one
        // - replace invoe by cached delegates
        public T SetObjectValues<T>(List<string> tokens, Type type, Boolean isSecondLayerCriteriaList, int logicDepth = 0) where T : Object, new()
        {
            //iterate through tokens until we reach a start of an object, in the first case the mainstory
            bool startNotFound = true;
            while (startNotFound)
            {
                //LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN0: {tokens[0]}");
                //go to first start or remove token
                if (tokens[0] == START_OBJECT)
                {
                    startNotFound = false;
                    tokens.RemoveAt(0);
                }
                else
                {
                    tokens.RemoveAt(0);
                }
            }

            Object retObject = CreateObject(type);
            LogWithLogicDepth(System.ConsoleColor.DarkGray, $"Created object of type {type.Name}", logicDepth);

            //if we can create a new T, get all methods, then calling all set methods using reflection, filling them up with the objects we need
            Il2CppReferenceArray<MethodInfo> methodInfos = type.GetMethods();

            //go through tokens to call the method we need, weith the token after as argument.
            string lastToken = "";
            bool remove;
            while (true)
            {
                remove = true;
                string token = tokens[0];
                LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN1: {token}", logicDepth);

                //list starts
                if (token == START_LIST)
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
                    tokens.RemoveAt(0);
                    token = tokens[0];

                    //get type from method signature
                    Type listType = getList.ReturnType;
                    Object list = CreateObject(listType);
                    MethodInfo listAdd = listType.GetMethod("Add");
                    LogWithLogicDepth(System.ConsoleColor.White, "created list", ++logicDepth);

                    //as long as we did not reach the end of the list, end it
                    while (tokens[0] != END_LIST)
                    {
                        LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN2: {token}", logicDepth);
                        Object objectToAdd;

                        if (!isSecondLayerCriteriaList.m_value && type == Il2CppType.Of<CriteriaList>())
                        {
                            isSecondLayerCriteriaList.m_value = true;
                            secondLayerCriteriaList = true;
                            //LogWithLogicDepth(System.ConsoleColor.White, $"is second list?: {isSecondLayerCriteriaList.m_value}", ++logicDepth);
                        }

                        if (token == START_OBJECT)
                        {
                            //add object
                            objectToAdd = SetObjectValues<Object>(tokens, FindTypeName(lastToken), isSecondLayerCriteriaList, logicDepth + 1);
                        }
                        else
                        {
                            //add string
                            objectToAdd = token;
                            tokens.RemoveAt(0);
                            token = tokens[0];
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
                else if (token == END_OBJECT)
                {
                    tokens.RemoveAt(0);

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
                            tokens.RemoveAt(0);
                            token = tokens[0];
                            LogWithLogicDepth(System.ConsoleColor.DarkGray, $"TOKEN3: {token}", logicDepth);

                            //get method parameter type so we can cast the string to the correct object
                            pType = methodInfo.GetParameterTypes()[0];

                            if (tokens[1] != START_LIST && tokens[1] != START_OBJECT)
                            {

                                //try parsing if necessary, defaults to new constructor like values
                                tokenObject = TryParseAll(pType, token);

                                methodInfo.Invoke(retObject, CreateReferenceArray(tokenObject));
                            }
                            else if (tokens[1] == START_OBJECT)
                            {

                                //try parsing if necessary, defaults to new constructor like values
                                tokenObject = SetObjectValues<Object>(tokens, pType, isSecondLayerCriteriaList, logicDepth + 1);

                                remove = false;
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
                    tokens.RemoveAt(0);
                }
            }
        }

        public List<string> SplitJson(string tempS)
        {
            List<string> tokens = new List<string>();

            bool inValueString = false;
            bool isEscaped = false;
            char c;
            //init stringbuilder with approximate buffer size for speed reasons (reduces resizing operations)
            StringBuilder stringBuilder = new StringBuilder(tempS.Length);


            for (int i = 0; i < tempS.Length; i++)
            {
                c = tempS[i];
                if (!isEscaped)
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
                        //add char to builder if it is not escaped
                        if (c == '\\')
                        {
                            isEscaped = true;
                            //dont copy escape character lol
                        }
                        else
                        {
                            stringBuilder.Append(c);
                        }
                    }
                    else if (IsInArray(seperators, c) && !inValueString)
                    {
                        //if we hit a seperator, add nonempty strings and clear string builder
                        if (stringBuilder.Length > 0) tokens.Add(stringBuilder.ToString());
                        if (c == '[') tokens.Add(START_LIST);
                        else if (c == ']') tokens.Add(END_LIST);
                        else if (c == '{') tokens.Add(START_OBJECT);
                        else if (c == '}') tokens.Add(END_OBJECT);
                        stringBuilder.Clear();
                    }
                    else
                    {
                        if (IsInArray(numbers, c))
                        {
                            //add char, in names and stuff
                            stringBuilder.Append(c);
                        }
                    }
                }
                else
                {
                    isEscaped = false;
                    //is escaped
                    stringBuilder.Append(c);
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
