using System.Reflection;

Assembly assembly = Assembly.LoadFrom("F:\\GameDeveloperLearning\\Player\\bin\\Debug\\Player.dll");
Type? player = assembly.GetType("Player.Player");
Activator.CreateInstance(player);
ConstructorInfo[] constructors = player.GetConstructors();
foreach (ConstructorInfo constructor in constructors)
{
    Console.WriteLine(constructor);
}