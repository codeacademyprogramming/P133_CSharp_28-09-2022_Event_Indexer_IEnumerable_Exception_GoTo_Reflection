using System;
using System.Reflection;

namespace ReflectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\hamid.mammadov\Desktop\P133DemoLibrary\P133DemoLibrary\bin\Debug\netcoreapp3.1\P133DemoLibrary.dll");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                //MemberInfo[] memberInfos = type.GetMembers(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

                //foreach (MemberInfo memberInfo in memberInfos)
                //{
                //    Console.WriteLine($"{memberInfo.Name} {memberInfo.DeclaringType} {memberInfo.MemberType}");
                //}

                if (type.Name == "MyClass")
                {
                    MethodInfo[] methodInfos = type.GetMethods();

                    foreach (MethodInfo methodInfo in methodInfos)
                    {
                        if (methodInfo.Name == "ShowInfo")
                        {

                            Console.WriteLine(methodInfo.ReturnType);
                            Console.WriteLine(methodInfo.GetParameters()[0]);
                            var ins = Activator.CreateInstance(type);

                            object[] parametrs = { "hamid" };

                            Console.WriteLine(methodInfo.Invoke(ins, parametrs));
                        }
                    }
                }
            }
        }
    }
}
