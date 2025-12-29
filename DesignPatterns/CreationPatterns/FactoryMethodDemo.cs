namespace DesignPatterns;
using static System.Console;

/// <summary>
/// The 'Product' abstract class
/// </summary>

public abstract class Page
{
    // Override. Display class name
    public override string ToString() => GetType().Name;
}

/// <summary>
/// A 'ConcreteProduct' class
/// </summary>
public class SkillsPage : Page
{
}

/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class EducationPage : Page
{
}

/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class ExperiencePage : Page
{
}

/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class IntroductionPage : Page
{
}

/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class ResultsPage : Page
{
}


/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class ConclusionPage : Page
{
}

/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class SummaryPage : Page
{
}

/// <summary>
/// A 'ConcreteProduct' Class
/// </summary>
public class BibliographyPage : Page
{
}

public abstract class Document
{
    // Gets list of document page
    public List<Page> Pages { get; protected set; } = null!;
    
    // Factory Method
    public abstract void CreatePages();
    
    //Override
    public override string ToString() => GetType().Name;
}

/// <summary>
/// A 'ConcreteCreator' Class
/// </summary>
public class  Resume : Document
{
    public override void CreatePages()
    {
        Pages =
        [
            new SkillsPage(),
            new EducationPage(),
            new ExperiencePage()
        ];
    }
}

public class Report : Document
{
    public override void CreatePages()
    {
        Pages = 
        [
            new IntroductionPage(),
            new ResultsPage(),
            new ConclusionPage(),
            new SummaryPage(),
            new BibliographyPage()
        ];
    }
}
public class FactoryMethodDemo
{
    public void Run()
    {
        // Document constructors call Factory Method
        List<Document> documents = [new Resume(), new Report()];

        foreach (var document in documents)
        {
            document.CreatePages();

            WriteLine($"{document} --");
            foreach (var page in document.Pages)
                WriteLine($"{page}");
            WriteLine();
        }
    }
}