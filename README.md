# Prog-M5

# Opdracht 1 (Herhaling: Functions, classes & arrays)

![gif](GIFS/Prog%20M5-1%20GIF.gif)

### Hier zie je dat wanneer de play-modus wordt gestart er 100 ballen op willekeurige plekken met willekeurige kleuren worden geïnstantieerd. Daarna zie je dat er elke seconde één bal word geïnstantieerd. Al deze ballen worden na elke 3 frames vernietigd.

### Dit komt doordat het material en de plek van de prefab van de bal die word geïnstantieert, zich per bal aanpast.

### De ballen worden vernietigd door een simpele 'Destroy' functie.

### In deze opdracht worden materials, vectors en 'Random.Range' gebruikt om dit resultaat te krijgen.

## SCRIPTS: 

[balls](Assets/Assets/Scripts/M5-1/M5-1/balls.cs)

# Opdracht 1.1 (Class, object, constructor & instantiate)

![gif](GIFS/Prog%20M5-1.1%20GIF.gif)

### Hier zie je dat wanneer er wordt geklikt er een cylinder met een willekeurige maat op een willekeurige plek wordt geplaatst.

### Dit werkt eigenlijk heel vergelijkbaar met het 'balls' script van opdracht 1.

### In deze opdracht wordt nogmaals gebruik gemaakt van vectors en 'Random.Range'
## SCRIPTS: 

[towerSpawner](/Assets/Assets/Scripts/M5-1/M5-1.1/towerSpawner.cs)

# Opdracht 1.2 (Arrays, lists & loops)

![gif](GIFS/Prog%20M5-1.2%20GIF.gif)

### Hier zie je dat wanneer de play-modus wordt gestart er elke seconde drie kubussen worden geïnstantieerd. Dit is eigenlijk hetzelfde verhaal als voor de voorgaande twee opdrachten waarin er prefabs worden hergebruikt.

### Als je de'W'toets indrukt, worden er in één keer 100 kubussen geïnstantieerd en als je de 'Q' toets indrukt worden alle geïnstantieerde objecten vernietigd.

## SCRIPTS: 

[enemyMove](Assets/Assets/Scripts/M5-1/M5-1.2/enemyMove.cs)

[enemySpawner](Assets/Assets/Scripts/M5-1/M5-1.2/enemySpawner.cs)

# Opdracht 2 (Action Events)

![gif](GIFS/Prog%20M5-2%20MP4.gif)

### Hier zie je dat wanneer de speler (Kubus) de ballen raakt, de score omhoog gaat en de geraakte bal verdwijnt.

### Dit komt doordat beide ballen een ander aantal punten geven en die aan de score toevoegen.

### In deze opdracht wordt een action event gebruikt om ervoor te zorgen dat twee samenwerkende scripts nog onafhankelijk van elkaar kunnen functioneren zonder een error te veroorzaken.

## SCRIPTS: 

[pickup](Assets/Assets/Scripts/M5-2/pickup.cs)

[scoreboard](/Assets/Assets/Scripts/M5-2/scoreboard.cs)

[playerMovement](/Assets/Assets/Scripts/M5-2/playerMovement.cs)

# Opdracht 3

## Debugging

### 3A

### Het antwoord op de eerste vraag van opdracht 3A: 

### Omdat de 'shotRange' 0 is.

### Dit kun je zien in aan de waardes die in Autos worden weergegeven.

### In het script staat: 

### if(delta.magnitude < shotRange && !inCooldown)

### Deze functie vraagt voor de waarde van de delta.magnitude kleiner te zijn dan de 'shotRange' en dat de boolean 'inCooldown' false is.

### In Autos kunnen we zien dat de waarde van de 'shotRange' 0 is.

### Dus de functie die vraagt voor de 'shotRange' om groter te zijn dan de delta.magnitude kan niet worden uitgevoerd.

### Het antwoord op de tweede vraag van opdracht 3A: 

### Omdat er twee verschillende waardes zijn ingevuld voor 'targetTag'. 'Player' en 'Playerr'.

### Dit kun je zien in aan de waardes die in Autos worden weergegeven.

### In het script staat: 

### targetTag = _targetTag

### Sinds 'Player' en 'Playerr' niet hetzelfde zijn, werken de functies die om die variabelen vragen niet correct.

### 3B

### (Staat in de issues in de repository)