// Variables
string bookmarkTitle = "Google";
string bookmarkURL = "https://www.google.com/";
bool isBookmarkFavorite = true;
DateTime bookmarkAddedDate = DateTime.Now;
int bookmarkPriority = 1;
float bookmarkRating = 4.5f;
char bookmarkStatus = 'N';
long bookmarkID = 8946513489;
string bookmarkCategory = "Productivity";


Console.WriteLine(bookmarkTitle);
Console.WriteLine(bookmarkURL);
Console.WriteLine(isBookmarkFavorite ? "Favorite" : "Not Favorite"); // Example of using ternary operator
Console.WriteLine(bookmarkAddedDate.ToString("yyyy/MM/dd")); // Formatting the DateTime
Console.WriteLine($"Bookmark Priority: {bookmarkPriority}");
Console.WriteLine("Rating of the bookmark: " + bookmarkRating);
Console.WriteLine("Bookmark Status: " + bookmarkStatus + ", where N: new, and R: read");
Console.WriteLine("Bookmark ID: " + bookmarkID);

// Control Structure
// if
if (isBookmarkFavorite == true)
{
    Console.WriteLine("This bookmark is favorite");
}

// if-else if
if (bookmarkStatus == 'N')
{
    Console.WriteLine("New Bookmark");
}
else if (bookmarkStatus == 'R')
{
    Console.WriteLine("Bookmark is read");
}

// if-else
if (bookmarkAddedDate.ToShortDateString() == DateTime.Now.ToShortDateString())
{
    Console.WriteLine("Today");
}
else
{
    Console.WriteLine("Recent");
}

// switch
switch (bookmarkCategory)
{
    case "Productivity":
        Console.WriteLine("This bookmark is related to productivity.");
        break;
    case "Entertainment":
        Console.WriteLine("This bookmark is related to entertainment.");
        break;
    case "Education":
        Console.WriteLine("This bookmark is related to education.");
        break;
    case "Social":
        Console.WriteLine("This bookmark is related to social media.");
        break;
    default:
        Console.WriteLine("This bookmark category is not recognized.");
        break;
}


// Struct
Bookmark bookmark = new Bookmark();
