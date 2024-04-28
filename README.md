<h1>API Dokumentation</h1>
<h2>Anrop för att hämta persondata</h2>
<h3>Anrop 1: Hämta alla personer</h3>
Metod: GET
Endpoint: /api/Person/GetAllPerson
Beskrivning: Hämtar information om alla personer i databasen.

<h3>Anrop 2: Hämta personens intressen baserat på ID</h3>
Metod: GET
Endpoint: /api/Person/GetPersonLinks/{Id}
Beskrivning: Hämtar länkar för en person baserat på deras ID.
Parametrar:
Id (int): ID för personen

<h3>Anrop 3: Hämta personens länkar baserat på ID</h3>
Metod: GET
Endpoint: /api/Person/GetPersonLinks/{Id}
Beskrivning: Hämtar länkar för en person baserat på deras ID.

<h2>Anrop för att lägga till data</h2>
<h3>Anrop 1: Lägg till intresse för en person</h3>
Metod: POST
Endpoint: /api/Person/AddInterest
Beskrivning: Lägger till ett intresse för en specifik person.
Parametrar:
personID (int): ID för personen
interest (int): ID för intresset

<h3>Anrop 2: Lägg till en länk för en person</h3>
Metod: POST
Endpoint: /api/Person/AddLink
Beskrivning: Lägger till en länk för en specifik person och intresse.
Parametrar:
personID (int): ID för personen
interestID (int): ID för intresset
url (string): URL för länken







