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

/// 
/// Ask the user for ther name
/// Ask how many they are in their party (groupo)
/// Keep track of how many people is in the party (fiesta)
/// At the end, print out the guest list and print the total number of guests
/// 

/// Concrete plan -- Tim Corey
/// 
/// Welcome the user
/// 
/// Ask user for name
/// Store the name (in a list, dictionary, tuple)
/// 
/// Ask user for the number in party
/// <convert string to number>/// 
/// Add the number to the total
/// 
/// Check to see if more guests are coming - none
/// Loop back to the top until no more guests
/// 
/// Loop over the names and print
/// Print the total guest count
/// 

/// My plan
/// 
/// Welcome the user
/// 
/// Ask user for name
/// <validate name>
/// 
/// Ask user for number
/// <convert string to number>
/// <validate the number is number and > 1 >
/// 
/// Store name and # party in a dictionary
/// 
/// Chect if there are more guests, none = no more
/// Loop back to the top until no more guests
///  
/// Print a report
/// <Loop over the dictionary keys and print>
/// Add dictionary values to an acumulative sum.
/// 
/// end

/// 
/// Class Guest -> metodos de los invitados... 
/// Welcome the users
/// AskGuetName
/// AskGuestParty
/// AddEntry
/// PrintReport
/// 

using GuestBook;


Guest.Welcome(); 

var guestBook = Guest.GetAllGuests();

Guest.PrintReport(guestBook);

Guest.GoodBye();






/// Planear la aplicación
/// Se planean los requisitos... 
/// Los requisitos muestran el resultado, No el como, ni el proceso lógico.
/// Hay requisitos explcítos. Están en el texto. 
/// Hay requisitos implícitos, la lógica que pretende alcanzar el resultado. Hay que asumirlos, inferirlos con exactitud para que el resultado sea correcto. De lo contrario, fracasarás. Es un ejercicio. Es práctica, la práctica de crear aplicaciones. Debes preguntarte ¿qué falta, qué lógica falta para alcanzar esos resultados?
/// Es decir, comienzas del final, e intentas recuperar los pasos que llevan a ese final.
/// Es una habilidad. De requisitos poco claros, vagos, plasmar un plan concreto y correcto. 
/// Se necesita entender la lógica detrás y preguntar.
/// 



