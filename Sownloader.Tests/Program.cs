// See https://aka.ms/new-console-template for more information
using Sownloader.Core;
using System.Reflection;

Version version = await UpdateSearch.SearchForUpdateAsync(Assembly.GetExecutingAssembly().GetName().Version);


Console.WriteLine(version);