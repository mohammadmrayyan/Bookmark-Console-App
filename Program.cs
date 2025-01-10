// // --------------- Variables ---------------
// string bookmarkTitle = "Google";
// string bookmarkURL = "https://www.google.com/";
// bool isBookmarkFavorite = true;
// DateTime bookmarkAddedDate = DateTime.Now;
// int bookmarkPriority = 1;
// float bookmarkRating = 4.5f;
// char bookmarkStatus = 'N';
// long bookmarkID = 8946513489;
// string bookmarkCategory = "Productivity";


// // Console.WriteLine(bookmarkTitle);
// // Console.WriteLine(bookmarkURL);
// // Console.WriteLine(isBookmarkFavorite ? "Favorite" : "Not Favorite"); // Example of using ternary operator
// // Console.WriteLine(bookmarkAddedDate.ToString("yyyy/MM/dd")); // Formatting the DateTime
// // Console.WriteLine($"Bookmark Priority: {bookmarkPriority}");
// // Console.WriteLine("Rating of the bookmark: " + bookmarkRating);
// // Console.WriteLine("Bookmark Status: " + bookmarkStatus + ", where N: new, and R: read");
// // Console.WriteLine("Bookmark ID: " + bookmarkID);

// // --------------- Control Structure ---------------
// // // if
// // if (isBookmarkFavorite)
// // {
// //     Console.WriteLine("This bookmark is favorite");
// // }

// // // if-else if
// // if (bookmarkStatus == 'N')
// // {
// //     Console.WriteLine("New Bookmark");
// // }
// // else if (bookmarkStatus == 'R')
// // {
// //     Console.WriteLine("Bookmark is read");
// // }

// // // if-else
// // if (bookmarkAddedDate.ToShortDateString() == DateTime.Now.ToShortDateString())
// // {
// //     Console.WriteLine("Today");
// // }
// // else
// // {
// //     Console.WriteLine("Recent");
// // }

// // // switch
// // switch (bookmarkCategory)
// // {
// //     case "Productivity":
// //         Console.WriteLine("This bookmark is related to productivity.");
// //         break;
// //     case "Entertainment":
// //         Console.WriteLine("This bookmark is related to entertainment.");
// //         break;
// //     case "Education":
// //         Console.WriteLine("This bookmark is related to education.");
// //         break;
// //     case "Social":
// //         Console.WriteLine("This bookmark is related to social media.");
// //         break;
// //     default:
// //         Console.WriteLine("This bookmark category is not recognized.");
// //         break;
// // }


// // --------------- Struct ---------------
// Bookmark googleBookmark = new Bookmark()
// {
//     title = bookmarkTitle,
//     URL = bookmarkURL,
//     isFavorite = isBookmarkFavorite,
//     addedDate = bookmarkAddedDate,
//     priority = bookmarkPriority,
//     rating = bookmarkRating,
//     status = bookmarkStatus,
//     ID = bookmarkID,
//     category = bookmarkCategory
// };

// // googleBookmark.title = bookmarkTitle;

// // Console.WriteLine(new string('-', 50));
// // Console.WriteLine(googleBookmark);

// // --------------- Bookmark Management using List ---------------

// // List<Bookmark> bookmarks = new List<Bookmark>() { googleBookmark };
// List<Bookmark> bookmarks = [googleBookmark];

// bookmarks.Add(new Bookmark()
// {
//     title = "YouTube",
//     URL = "https://www.youtube.com/",
//     isFavorite = true,
//     addedDate = DateTime.Now,
//     priority = 2,
//     rating = 4.8f,
//     status = 'N',
//     ID = 8946513490,
//     category = "Entertainment"
// });

// bookmarks.Add(new Bookmark()
// {
//     title = "Udemy",
//     URL = "https://www.udemy.com/",
//     isFavorite = false,
//     addedDate = DateTime.Now,
//     priority = 3,
//     rating = 4.9f,
//     status = 'N',
//     ID = 8946513491,
//     category = "Education"
// });

// bookmarks.Add(new Bookmark()
// {
//     title = "Facebook",
//     URL = "https://www.facebook.com/",
//     isFavorite = true,
//     addedDate = DateTime.Now,
//     priority = 4,
//     rating = 4.7f,
//     status = 'N',
//     ID = 8946513492,
//     category = "Social"
// });


// // --------------- Loop ---------------
// // for loop
// for (int i = 0; i < bookmarks.Count; i++)
// {
//     Console.WriteLine($"{i + 1}. {bookmarks[i].title}");
// }
// Console.WriteLine(new string('-', 50));
// // foreach loop
// foreach (var item in bookmarks)
// {
//     Console.WriteLine(item.URL);
// }

BookmarkManagement bookmarkManagement = new BookmarkManagement();
bookmarkManagement.AddBookmark("Google", "https://www.google.com/", BookmarkManagement.BookmarkCategory.Education);
bookmarkManagement.AddBookmark("YouTube", "https://www.youtube.com/", BookmarkManagement.BookmarkCategory.Entertainment);
bookmarkManagement.AddBookmark("Udemy", "https://www.udemy.com/", BookmarkManagement.BookmarkCategory.Education);
bookmarkManagement.AddBookmark("Facebook", "https://www.facebook.com/", BookmarkManagement.BookmarkCategory.Personal);
bookmarkManagement.AddBookmark("Twitter", "https://www.twitter.com/", BookmarkManagement.BookmarkCategory.Personal);
bookmarkManagement.AddBookmark("LinkedIn", "https://www.linkedin.com/", BookmarkManagement.BookmarkCategory.Work);

// while loop (for menu)
string? userChoice = "";

while (userChoice != "0")
{
    // CRUD operations on bookmarks (Create, Read, Update, Delete)
    DisplayMenu();
    userChoice = Console.ReadLine();
    Console.Clear();

    switch (userChoice)
    {
        case "1":
            bookmarkManagement.DisplayBookmarks();
            break;
        case "2":
            Console.WriteLine("Adding Bookmark will be implemented here.");
            break;
        case "3":
            Console.WriteLine("Removing Bookmark will be implemented here.");
            break;
        case "4":
            do
            {
                Console.WriteLine("Showing Bookmarks...");
                Console.WriteLine("Updating Bookmark will be implemented here.");
                Console.WriteLine("Do you want to continue updating bookmarks? (Y/N)");
                userChoice = Console.ReadLine();
            } while (userChoice.ToUpper() == "Y");
            break;
        case "0":  // Exit
            Console.WriteLine("Exiting the application.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
    Console.Write("Hit Enter to Continue");
    Console.ReadLine();
}

// --------------- Functions ---------------
void DisplayMenu()
{
    Console.WriteLine(new string('-', 50));
    Console.WriteLine("1. Show Bookmarks"); // Read
    Console.WriteLine("2. Add Bookmark"); // Create
    Console.WriteLine("3. Remove Bookmark"); // Delete
    Console.WriteLine("4. Update Bookmark"); // Update
    Console.WriteLine("0. Exit");
    Console.Write("Enter your choice: ");
}