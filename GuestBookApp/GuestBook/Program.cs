// Guest Book APP


/// Console Guest Book App
/// 

/// Recommendations
/// Do not assume anything. Do not get confuse by the requirements
/// Use methods in a new Class
/// Use dry, 
/// Single responsibility, 
/// right naming, 
/// readability of code -> count a story of what is doing
/// 

/// Test 
/// name > ""
///      > "none"
///      > happy edge
/// partyNumber > notNumber
///             > -1
///             > happy edge
/// lista invitados
/// Total de invitados
/// 
/// OK

/// Plan>
/// 
/// Ask the user for ther name
/// Ask how many they are in their party (groupo)
/// Keep track of how many people is in the party (fiesta)
/// At the end, print out the guest list and print the total number of guests
/// 

/// Class Guest -> metodos de los invitados... 
/// AskGuetName
/// AskGuestParty
/// AddEntry
/// PrintReport
/// 

using GuestBook;

string guestName;
int partyNumber;
Dictionary<string, int> guestBook = new();

do
{
    Guest.Welcome(); 

    guestName = Guest.AskGuestName();

    if (guestName.ToLower() != "none")
    {
        partyNumber = Guest.AskGuestParty();

        guestBook = Guest.AddEntry(guestBook, guestName, partyNumber);
    }

} while (guestName.ToLower() != "none");

Guest.PrintReport(guestBook);




