using System;
usingSystem.Collections.Generic;
usingSystem.Linq;
usingSystem.Text;
usingSystem.Threading.Tasks;

namespace Delegates
{

//Делегаты - аналог процедурного типа в Паскале.
//Делегат - это не тип класса, а тип метода.
//Делегат определяет сигнатуру метода (типы параметров и возвращаемого значения).
//Если создается метод типа делегата, то у него должна быть сигнатура как у делегата.
//Метод типа делегата можно передать как параметр другому методу.

//Название делегата при объявлении указывается "вместо" названия метода
delegateintPlusOrMinus(int p1, int p2);

    classProgram
    {
//Методы, реализующие делегат (методы "типа" делегата)
staticintPlus(int p1, int p2)
    { return p1 + p2; }
staticintMinus(int p1, int p2) { return p1 - p2; }

///<summary>
/// Использование обощенного делегата Func<>
///</summary>
staticvoidPlusOrMinusMethodFunc(stringstr, int i1, int i2, Func<int, int, int> PlusOrMinusParam)
    {
        int Result = PlusOrMinusParam(i1, i2);
        Console.WriteLine(str + Result.ToString());

        // Func<int, string, bool> - делегат принимает параметры типа int и string и возвращает bool

        // Если метод должен возвращать void, то используется делегат Action
        // Action<int, string> - делегат принимает параметры типа int и string и возвращает void
        // Action как правило используется для разработки групповых делегатов, которые используются в событиях 

    }

///<summary>
///Использованиеделегата
///</summary>
staticvoidPlusOrMinusMethod(stringstr, int i1, int i2, PlusOrMinusPlusOrMinusParam)
    {
        int Result = PlusOrMinusParam(i1, i2);
        Console.WriteLine(str + Result.ToString());
    }

    staticvoid Main(string[] args)
    {
        int i1 = 3;
        int i2 = 2;

        PlusOrMinusMethod("Плюс: ", i1, i2, Plus);
        PlusOrMinusMethod("Минус: ", i1, i2, Minus);

        //Создание экземпляра делегата на основе метода
        PlusOrMinuspm1 = newPlusOrMinus(Plus);
        PlusOrMinusMethod("Создание экземпляра делегата на основе метода: ", i1, i2, pm1);

        //Создание экземпляра делегата на основе 'предположения' делегата
        //Компилятор 'пердполагает' что метод Plus типа делегата
        PlusOrMinus pm2 = Plus;
        PlusOrMinusMethod("Создание экземпляра делегата на основе 'предположения' делегата: ", i1, i2, pm2);

        //Созданиеанонимногометода
        PlusOrMinus pm3 = delegate (int param1, int param2)
        {
            return param1 + param2;
        };
        PlusOrMinusMethod("Созданиеэкземпляраделегатанаосновеанонимногометода: ", i1, i2, pm2);

        //Лямбда-выражение в виде переменной
        PlusOrMinus pm4 = (int x, int y) =>
        {
            int z = x + y;
            return z;
        };
        inttest = pm4(1, 2);
        PlusOrMinusMethod("Создание экземпляра делегата на основе лямбда-выражения в виде переменной: ", i1, i2, pm4);

        //Пример использования внешней переменной
        intouter = 100;
        PlusOrMinus pm5 = (int x, int y) =>
        {
            int z = x + y + outer;
            return z;
        };
        int test2 = pm5(1, 2);

        PlusOrMinusMethod("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
        (int x, int y) =>
        {
            int z = x + y;
            return z;
        }
                        );

        PlusOrMinusMethod("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
        (x, y) =>
        {
            return x + y;
        }
                        );

        PlusOrMinusMethod("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x + y);



        ////////////////////////////////////////////////////////////////
        Console.WriteLine("\n\nИспользованиеобощенного делегата Func<>");

        PlusOrMinusMethodFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Plus);

        stringOuterString = "ВНЕШНЯЯ ПЕРЕМЕННАЯ";

        PlusOrMinusMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                        (int x, int y) =>
                        {
                            Console.WriteLine("Эта переменная объявлена вне лямбда-выражения: " + OuterString);
                            int z = x + y;
                            return z;
                        }
                        );

        PlusOrMinusMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
        (x, y) =>
        {
            return x + y;
        }
                        );

        PlusOrMinusMethodFunc("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x + y);


        //////////////////////////////////////////////////////////////
        //Групповой делегат всегда возвращает значение типа void
        Console.WriteLine("Пример группового делегата");
        Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} + {1} = {2}", x, y, x + y); };
        Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} - {1} = {2}", x, y, x - y); };
        Action<int, int> group = a1 + a2;
        group(5, 3);

        Action<int, int> group2 = a1;
        Console.WriteLine("Добавление вызова метода к групповому делегату");
        group2 += a2;
        group2(10, 5);
        Console.WriteLine("Удаление вызова метода из группового делегата");
        group2 -= a1;
        group2(20, 10);

        Console.ReadLine();
    }
}
}
2.	РЕФЛЕКСИЯ
3.	usingSystem;
4.	usingSystem.Collections.Generic;
5.	usingSystem.Linq;
6.	usingSystem.Reflection;
7.	usingSystem.Text;
8.	publicclassForInspection :IComparable
9.	    {
10.	publicForInspection() { }
11.	publicForInspection(int i) { }
12.	publicForInspection(stringstr) { }
13.	
14.	publicintPlus(int x, int y) { return x + y; }
15.	publicintMinus(int x, int y) { return x - y; }
16.	
17.	[NewAttribute("Описание для property1")]
18.	publicstring property1
19.	        {
20.	get{ return _property1; }
21.	set{ _property1 = value; }
22.	        }
23.	privatestring _property1;
24.	
25.	publicint property2 { get; set; }
26.	
27.	        [NewAttribute(Description = "Описаниедля property3")]
28.	publicdouble property3 { get; privateset; }
29.	
30.	publicint field1;
31.	publicfloat field2;
32.	
33.	///<summary>
34.	/// Реализация интерфейса IComparable
35.	///</summary>
36.	publicintCompareTo(objectobj)
37.	{
38.	return 0;
39.	        }
40.	    }
41.	namespaceReflection
42.	{
43.	///<summary>
44.	/// Класс атрибута 
45.	///</summary>
46.	    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
47.	publicclassNewAttribute :Attribute
48.	    {
49.	publicNewAttribute() { }
50.	publicNewAttribute(stringDescriptionParam)
51.	        {
52.	Description = DescriptionParam;
53.	        }
54.	
55.	publicstring Description { get; set; }
56.	}
57.	}
58.	
59.	namespaceReflection
60.	{
61.	classProgram
62.	    {
63.	///<summary>
64.	/// Проверка, что у свойства есть атрибут заданного типа
65.	///</summary>
66.	///<returns>Значение атрибута</returns>
67.	publicstaticboolGetPropertyAttribute(PropertyInfocheckType, TypeattributeType, outobject attribute)
68.	{
69.	boolResult = false;
70.	attribute = null;
71.	
72.	//Поиск атрибутов с заданным типом
73.	varisAttribute = checkType.GetCustomAttributes(attributeType, false);
74.	if (isAttribute.Length> 0)
75.	            {
76.	Result = true;
77.	attribute = isAttribute[0];
78.	            }
79.	
80.	returnResult;
81.	        }
82.	
83.	///<summary>
84.	/// Получение информации о текущей сборке
85.	///</summary>
86.	staticvoidAssemblyInfo()
87.	        {
88.	Console.WriteLine("Вывод информации о сборке:");
89.	Assembly i = Assembly.GetExecutingAssembly();
90.	Console.WriteLine("Полноеимя:" + i.FullName);
91.	Console.WriteLine("Исполняемыйфайл:" + i.Location);
92.	}
93.	
94.	///<summary>
95.	/// Получение информации о типе
96.	///</summary>
97.	staticvoidTypeInfo()
98.	        {
99.	ForInspectionobj = newForInspection();
100.	Type t = obj.GetType();
101.	
102.	//другой способ
103.	//Type t = typeof(ForInspection);
104.	
105.	Console.WriteLine("\nИнформация о типе:");
106.	Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
107.	Console.WriteLine("Пространство имен " + t.Namespace);
108.	Console.WriteLine("Находитсявсборке " + t.AssemblyQualifiedName);
109.	
110.	Console.WriteLine("\nКонструкторы:");
111.	foreach (var x int.GetConstructors())
112.	{
113.	Console.WriteLine(x);
114.	            }
115.	
116.	Console.WriteLine("\nМетоды:");
117.	foreach (var x int.GetMethods())
118.	{
119.	Console.WriteLine(x);
120.	            }
121.	
122.	Console.WriteLine("\nСвойства:");
123.	foreach (var x int.GetProperties())
124.	{
125.	Console.WriteLine(x);
126.	            }
127.	
128.	Console.WriteLine("\nПоляданных (public):");
129.	foreach (var x int.GetFields())
130.	{
131.	Console.WriteLine(x);
132.	            }
133.	
134.	Console.WriteLine("\nForInspectionреализуетIComparable -> " +
135.	t.GetInterfaces().Contains(typeof(IComparable))
136.	);
137.	        }
138.	
139.	///<summary>
140.	/// Пример использования метода InvokeMember
141.	///</summary>
142.	staticvoidInvokeMemberInfo()
143.	        {
144.	Type t = typeof(ForInspection);
145.	Console.WriteLine("\nВызов метода:");
146.	
147.	//Создание объекта
148.	//ForInspectionfi = newForInspection();
149.	//Можно создать объект через рефлексию
150.	ForInspection fi = (ForInspection)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, newobject[] { });
151.	
152.	//Параметры вызова метода
153.	object[] parameters = newobject[] { 3, 2 };
154.	//Вызов метода
155.	object Result = t.InvokeMember("Plus", BindingFlags.InvokeMethod, null, fi, parameters);
156.	Console.WriteLine("Plus(3,2)={0}", Result);
157.	        }
158.	
159.	///<summary>
160.	/// Работа с атрибутами
161.	///</summary>
162.	staticvoidAttributeInfo()
163.	        {
164.	Type t = typeof(ForInspection);
165.	Console.WriteLine("\nСвойства, помеченные атрибутом:");
166.	foreach (var x int.GetProperties())
167.	{
168.	objectattrObj;
169.	if (GetPropertyAttribute(x, typeof(NewAttribute), outattrObj))
170.	{
171.	NewAttributeattr = attrObjasNewAttribute;
172.	Console.WriteLine(x.Name + " - " + attr.Description);
173.	}
174.	            }
175.	        }
176.	
177.	staticvoid Main(string[] args)
178.	{
179.	AssemblyInfo();
180.	TypeInfo();
181.	InvokeMemberInfo();
182.	AttributeInfo();
183.	
184.	Console.ReadLine();
185.	        }
186.	    }
187.	}
