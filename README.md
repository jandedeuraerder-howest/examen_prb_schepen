# Examen PRB 
### Datum : maandag 2/12/2019
### Examentijd : 18:00-21:00
### Examengroep : S1&S2 – PROG – A – Programming basics – zaterdagvoormiddag
## Afspraken :
-	Je maakt deze opdracht individueel
-	Indienen doe je via een commit naar github.  Vraag je docent na te kijken of alles correct verlopen is.
-	Je mag enkel gebruik maken van je syllabus, eerder gemaakte oefeningen/opdrachten en zoekopdrachten op internet.  Je mag geen gebruik maken van chat, fora … of welk ander communicatiemiddel dan ook.

## Het WPF venster :

! img1.png














LEES DE OPDRACHT EERST HELEMAAL VOORALEER JE GAAT PROGRAMMEREN !
De applicatie houdt informatie bij van schepen : de naam (string), het type (string), het aantal bemanningsleden (int) en de snelheid (byte) dat het schip kan varen.
Voorzie in een afzonderlijke class library een klasse (Schip) dat deze eigenschappen heeft (gebruik full properties).
Deze klasse dient over een constructor te beschikken die deze 4 waarden ontvangt.
Deze klasse dient eveneens de ToString() methode te overschrijven.  Wanneer we straks onze schepen gaan afbeelden in lstSchepen dan dient daar de naam + het type van het schip in te verschijnen.
Wanneer een nieuw schip wordt toegevoegd dan : 
•	Is de naam vereist : je hoeft NIET te controleren op eventuele dubbels
•	Is het type vereist : dit wordt gekozen aan de hand van waarden in cmbScheepstype (zie verder)
•	Is het aantal bemanningsleden vereist.  Dit dient minimaal 1 te zijn.
•	Is de snelheid (knopen) vereist.  Dit dient minimaal 0 te zijn.
Bij het starten van je programma dient cmbScheepstype gevuld te worden.  Je doet dit met volgende waarden : Zeilboot, Roeiboot, Motorboot, Passagiersschip, Containerschip en Oorlogsschip.
Daarnaast dient bij het starten nog volgende te gebeuren : 
•	grpSchepen wordt ingeschakeld
•	grpDetails wordt uitgeschakeld
•	grpBewerken wordt zichtbaar
•	btnAnnuleren wordt onzichtbaar
•	btnBewaren wordt onzichtbaar
De schepen die je straks gaat toevoegen dienen in een list bewaard te worden.  Maak deze list dus globaal aan.
Wanneer op btnNieuw en btnWijzig wordt geklikt dan dient het volgende te gebeuren : 
•	grpSchepen wordt uitgeschakeld
•	grpDetails wordt ingeschakeld
•	grpBewerken wordt onzichtbaar
•	btnAnnuleren wordt zichtbaar
•	btnBewaren wordt zichtbaar
Wanneer op btnAnnuleren of btnBewaren wordt geklikt dient (onder andere) volgende te gebeuren : 
•	grpSchepen wordt ingeschakeld
•	grpDetails wordt uitgeschakeld
•	grpBewerken wordt zichtbaar
•	btnAnnuleren wordt onzichtbaar
•	btnBewaren wordt onzichtbaar
Bij btnBewaren hou je er uiteraard rekening mee of het om een nieuw schip gaat, of over het aanpassen van een bestaand schip.
Voorzie de nodige foutopvang en geef de gebruiker bruikbare feedback bij fouten.
Wanneer een nieuw schip wordt toegevoegd of wanneer een bestaand schip werd gewijzigd dient lstSchepen gevuld te worden met alle waarden uit de globale list.
Zorg hier meteen ook voor het opvullen van de statistieken : 
•	in lblSnelsteSchip komt de naam, het type en de snelheid van het snelste schip in de list.
•	In lblGrootsteSchip komt de naam, het type en het aantal bemanningsleden van het schip dat de meeste bemanningsleden telt
•	In tbkAantalPerSoort geef je per scheepstype aan hoeveel ervan in onze list aanwezig zijn.
Wanneer in lstSchepen een schip wordt geselecteerd dan dienen de detailgegevens van dit schip afgebeeld te worden in de corresponderende controls van grpDetails.
Wanneer een schip wordt verwijderd, dan dient deze uit de list verwijderd te worden, uit lstSchepen verwijderd te worden, en dienen de statistieken bijgewerkt te worden.

Hieronder nog een afbeelding van het programma dat wat schepen bevat : 

 




