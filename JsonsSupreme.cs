//#define verbose

using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using MelonLoader;
using System.Runtime.CompilerServices;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using Object = Il2CppSystem.Object;

namespace HPCSC
{

    sealed class JsonsSupreme
    {
        private readonly Il2CppReferenceArray<Object> objectReferenceArray = new Il2CppReferenceArray<Object>(1);
        private Type stringListType;

        private bool secondLayerCriteriaList = false;
        private readonly Il2CppReferenceArray<MethodInfo>[] MethodInfoList = new Il2CppReferenceArray<MethodInfo>[45];
        private readonly static char[] numbers = new char[] { '0', '1', '2', '3', '4', '4', '5', '6', '7', '8', '9', '.', 'n', 'u', 'l', 'f', 'a', 's', 'r', 't', 'e' };
        private readonly static char[] seperators = new char[] { '{', '}', '[', ']', ',', ':' };
        private static Boolean system_Boolean = new Boolean();
        private static Int32 system_Int32 = new Int32();
        private Type[] TypeList;

        private Il2CppReferenceArray<Object> MakeReferenceArray(Object @object)
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
            ClassInjector.RegisterTypeInIl2Cpp<CharacterItemGroupInteraction>();
            ClassInjector.RegisterTypeInIl2Cpp<BackgroundChatter>();
            ClassInjector.RegisterTypeInIl2Cpp<Valuee>();
            ClassInjector.RegisterTypeInIl2Cpp<Personality>();
            ClassInjector.RegisterTypeInIl2Cpp<ExtendedDetail>();
            ClassInjector.RegisterTypeInIl2Cpp<Quest>();
            ClassInjector.RegisterTypeInIl2Cpp<Reaction>();
            ClassInjector.RegisterTypeInIl2Cpp<StoryItem>();
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

            for (int i = 0; i < TypeList.Length; i++)
            {
                MethodInfoList[i] = TypeList[i].GetMethods();
            }

            stringListType = Il2CppType.Of<List<string>>();
        }

        private static bool IsInArray(char[] arr, char c)
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

        public static void LogWithLogicDepth(System.ConsoleColor color, string text, int logicDepth,
    [CallerLineNumber] int lineNumber = 0,
    [CallerMemberName] string caller = null)
        {
            MelonLogger.Msg(color, $"|>{logicDepth} - {caller}@{lineNumber}| {text}");
        }

        private Il2CppReferenceArray<MethodInfo> GetMethodInfos(Type type)
        {
            for (int i = 0; i < MethodInfoList.Length; i++)
            {
                if (TypeList[i] == type)
                {
                    return MethodInfoList[i];
                }
            }
            return type.GetMethods();
        }

        private MethodInfo GetSetMethodInfo(Type type, string token)
        {
            return GetSetMethodInfo(GetMethodInfos(type), token);
        }

        private MethodInfo GetSetMethodInfo(Il2CppReferenceArray<MethodInfo> methodInfos, string token)
        {
            for (int i = 0; i < methodInfos.Count; i++)
            {
                MethodInfo methodInfo = methodInfos[i];
                if (methodInfo.Name.ToLower() == $"Set{token}".ToLower())
                {
                    return methodInfo;
                }
            }
            throw new System.NotSupportedException($"Set{token} can not be found, check token order");
        }

        private MethodInfo GetGetMethodInfo(Type type, string token)
        {
            return GetGetMethodInfo(GetMethodInfos(type), token);
        }

        private MethodInfo GetGetMethodInfo(Il2CppReferenceArray<MethodInfo> methodInfos, string token)
        {
            for (int i = 0; i < methodInfos.Count; i++)
            {
                MethodInfo methodInfo = methodInfos[i];
                if (methodInfo.Name.ToLower() == $"Get{token}".ToLower())
                {
                    return methodInfo;
                }
            }
            throw new System.NotSupportedException($"Get{token} can not be found, check token order");
        }

        private Object CreateObject(Type type)
        {
            //MelonLogger.Msg(type.Name); seems right for 
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
            else if (type == Il2CppType.Of<string>()) { return ""; }
            else { MelonLogger.Msg($"Type '{type.Name}' not yet added to elseif"); return new Object(); }
        }

        //todo speed increase:
        // - change order of building, create all params first, then create object with all parameters to not call all set mothods one by one
        // - worst case: hard type all
        // - per wurzel: remove the need for the queue by using a streamreader directly in the same place as creating the objects (would get rid of the part where i have to parse the tokens)

        public T SetObjectValues<T>(Queue<string> tokens, Type type, int logicDepth = 0) where T : Object, new()
        {
            MethodInfo setList, currentMethod, listAdd;
            string lastToken = "", token;
            Type pType;
            //create return object
            Object returnObject = CreateObject(type);
            //get first token
            token = tokens.Dequeue();
            //go through tokens to call the method we need, with the token after as argument.
            while (true)
            {
                //new object begins, we can call on methods on this
                if (token == "START_OBJECT")
                {//we need to get rid of the first beginning token
                    token = tokens.Dequeue();
                }
                else if (token == "START_LIST")
                {//list as a value
                    //get rid of the next start obejcts token
                    if (tokens.Dequeue() == "END_LIST")
                    {
                        //break out, list is empty anyways
                        token = tokens.Dequeue();
                        continue;
                    }
                    setList = GetSetMethodInfo(type, lastToken);
                    pType = setList.GetParameterTypes()[0];

                    Object list = CreateObject(pType);
                    listAdd = pType.GetMethod("Add");

                    if (pType == stringListType)
                    {//list of strings
                        while (token != "END_LIST")
                        {
                            //list.Cast<List<Object>>().Add(token);
                            listAdd.Invoke(list, MakeReferenceArray(token));

                            token = tokens.Dequeue();
                        }
                    }
                    else
                    {
                        while (token != "END_LIST")
                        {//list of objects  
                            //LogWithLogicDepth(System.ConsoleColor.DarkGray, $"{returnObject.GetIl2CppType().Name} |adding object of type: {lastToken} to list of type {pType.Name}-{pType.GenericTypeArguments[0].Name}", logicDepth);
                            listAdd.Invoke(list, MakeReferenceArray(SetObjectValues<Object>(tokens, pType.GenericTypeArguments[0], logicDepth + 1)));
                            //LogWithLogicDepth(System.ConsoleColor.DarkGray, $"{returnObject.GetIl2CppType().Name} |added object of type: {lastToken} to list of type {pType.Name}-{pType.GenericTypeArguments[0].Name}", logicDepth);

                            //either start_object or end_list
                            token = tokens.Dequeue();
                        }
                    }
                    setList.Invoke(returnObject, MakeReferenceArray(list));

                    token = tokens.Dequeue();
                }
                else if (token == "END_OBJECT")
                {//return
                    if (type == TypeList[8] && secondLayerCriteriaList)
                    {
                        secondLayerCriteriaList = false;
                    }
                    //LogWithLogicDepth(System.ConsoleColor.DarkGray, $"{type.Name} |return object of type {returnObject.GetIl2CppType().Name}", logicDepth);
                    return returnObject.Cast<T>();
                }
                else
                {//either key or value, should only be a key
                    currentMethod = GetSetMethodInfo(type, token);
                    //get value
                    lastToken = token;
                    token = tokens.Dequeue();
                    //get type
                    pType = currentMethod.GetParameterTypes()[0];

                    if (token == "START_LIST")
                    {
                        //do nothing
                        continue;
                    }
                    else if (token == "START_OBJECT")
                    {
                        //complex type, go in recusrive and set all values, then add here
                        //invoke method and add object
                        currentMethod.Invoke(returnObject, MakeReferenceArray(SetObjectValues<Object>(tokens, pType, logicDepth + 1)));
                    }
                    else
                    {
                        //simple type, can "parse"
                        //invoke method and add object
                        currentMethod.Invoke(returnObject, MakeReferenceArray(TryParseAll(pType, token)));
                    }

                    //set new token for new loop iteration
                    token = tokens.Dequeue();
                }
            }
        }

        public static Queue<string> SplitJson(string tempS)
        {
            Queue<string> tokens = new Queue<string>(300000);
            bool inValueString = false;
            bool isEscaped = false;
            bool emptyValue = false;
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
                                if (stringBuilder.Length == 0)
                                {
                                    emptyValue = true;
                                }
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
                            if (stringBuilder.Length > 0 || emptyValue)
                            {
                                emptyValue = false;
                                tokens.Enqueue(stringBuilder.ToString());
                                stringBuilder.Clear();
                            }

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

            MelonLogger.Msg("Finished tokenization");

            return tokens;
        }

        private static Object TryParseAll(Type type, string token)
        {
            try
            {
                //MelonLogger.Msg($"Type to convert to: {type.FullName}, token: {token}");
                //try casting the types, revert to default if failed
                switch (type.Name)
                {
                    case "Boolean":
                        system_Boolean.m_value = bool.Parse(token);
                        return system_Boolean.BoxIl2CppObject();
                    case "Int32":
                        system_Int32.m_value = int.Parse(token, System.Globalization.NumberStyles.Integer);
                        return system_Int32.BoxIl2CppObject();
                    case "String":
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
