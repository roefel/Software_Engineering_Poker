# Software_Engineering_Poker

Wegens het gebrek aan kennis van windows Forms (vorig jaar hebben we enkel console applicaties moeten maken), krijgen we bepaalde visuele elementen niet geüpdate. Na uren (letterlijk) zoeken, hadden we online nog steeds geen oplossing gevonden voor deze problemen. Refresh, Invalidate, Update, etc. werkten allemaal niet om de kaarten te updaten. Ook krijgen we nergens een error die ons een mogelijke draad geeft. Enkel tijdens het debuggen kwamen we af en toe een null reference tegen, maar daar werden we ook niet veel wijzer van.

Vandaar dat de functies RandomCard() en UpdateTableMoney() niet op een correcte manier konden worden gebruikt. Voor Deze 2 functies werden dan ook alternatieven ingesteld. RandomCard() heeft een button gekregen die de functie aanroept en een kaart teruggeeft in de console. Oorspronkelijk was het de bedoeling om voor elke kaart die moest worden gekozen (voor speler, computer en dealer), we deze functie zouden aanroepen. Jammer genoeg kregen we de pictureboxes niet opgelost en hebben we de functie dan maar een beetje aangepast zodat er nu in de console telkens een kaart wordt gegenereerd tot dat uiteindelijk alle 52 kaarten getrokken zijn.

Voor de speler staan 2 default kaarten wel al aangeduid, deze zijn niet gebonden met de functie aangezien ook deze niet meer wilden updaten van zodra de applicatie loopt.
UpdateTableMoney() kreeg ook een eigen knop zodat de visuele kant daarvan wordt aangestuurt vanuit de UI klasse zelf. Iets wat niet de bedoeling is, en ook niet de bedoeling was.

De pijlen die zichtbaar zijn, zijn bedoeld om de huidige speler's beurt aan te geven. Deze wilden we om te beurten laten verschijnen door de pciturebox visible en invisble te stellen, maar ook dit kon niet worden aangestuurd.

Verschillende functies werden nog wel uitgeschreven (zoals bijvoorbeeld het berekenen van de winnende kaarten), maar werden jammer genoeg niet visueel gebruikt gemaakt vanwege het probleem met de pcitureboxen die niet willen updaten tijdens de applicatie.