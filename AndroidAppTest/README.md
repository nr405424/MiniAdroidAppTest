# MiniAdroidAppTest

OUTILS

- Unity 2019.4.0f1 (LTS) avec Android Build Support + Android SDK & NDK Tools + OpenJDK
- Android Studio

FONCTIONNALITES

- Le bouton Toast fait apparaitre un toast message (qu'on peut modifier dans l'inspector)
- Le bouton Vibrate fait vibrer le portable
- Un bouton pour quitter
- Le build 

PROCEDURE

-	J'ai créé un nouveau projet dans Unity contenant deux boutons : un pour toast et un pour vibrate.
	Après l'avoir exporté, j'ai ensuite ouvert le projet dans Android Studio.

-	J'ai ensuite créé nouveau module "Android Library" (en java) dans Android Studio pour pouvoir
	récuperer un plugin .aar, et pour avoir une communication Java <> C#, j'ai dû copier le fichier
	unity-classes.jar présent dans le dossier libs de mon projet et le coller dans celui de mon nouveau
	module, ce qui me permet d'acceder à UnityPlayer.

-	Mon fichier java contient deux méthodes :
		-> une méthode pour créer un toast message
		-> une méthode pour faire vibrer le portable (en fonction de sa version d'API)

-	Après avoir clean et build dans le gradle de mon module, j'ai mis le .aar généré dans le fichier
	Assets de mon projet Unity. Les méthodes appelées dans mon script C# par les boutons Toast et Vibrate
	font donc référence aux méthodes de mon plugin .aar

COMPLICATIONS

-	L'installation du module Android Build Support + Android SDK & NDK Tools + OpenJDK pour Unity ainsi que
	l'installation du logiciel Android Studio ont pris énormément de temps.

-	Android Studio impacte beaucoup la performance de mon ordinateur.

-	Des problèmes d'espace d'ordinateur.

PROBLEMES RENCONTRES

-	Des incompatibilités entre les versions d'API et de SDK. J'ai dû télécharger des nouveaux SDK dans Android
	Studio pour avoir la même version utilisée dans Unity.

-	Vu que Unity peut afficher ses propres toast messages, j'ai perdu un peu de temps à croire que mon fichier C#
	n'arrivait pas à utiliser mon plugin android car le toast message n'apparait pas dans la game view quand
	je clique sur le bouton toast. Le message n'apparassait pas non plus dans mon portable, qui est connecté
	avec le projet via Unity Remote 5. Par conséquence, j'ai essayé plusieurs fois différentes méthodes pour
	afficher un toast via Android Studio. Après quelques essais, j'ai decidé de faire un build et de le mettre
	directement dans mon portable, ce qui a marché. Je ne suis pas exactement certaine, je pense que peut-être
	Unity n'est pas capable d'afficher des contenus créés par Android Studio ?

-	Je n'étais pas très familère à la communication entre Java et C# en utilisant à la fois Unity et Android
	Studio, dont la necessité pour moi de consacrer du temps à lire la documentation, faire des recherches, et
	faire des essaies et erreurs. Par exemple, je n'arrivais pas à générer un fichier .jar, ce qui m'a incité
	d'essayer de générer un fichier .aar, ce qui semblait plus simple.

-	J'ai décidé de vous envoyer mon rendu sans le http callback car j'ai déjà passé du temps pour en arriver à
	ce résultat (1 journée / 2). Sachant que je vais prendre du temps à l'implémenter, j'ai préféré vous envoyer
	un résultat fonctionnel que j'ai testé, plutôt que de tarder à rendre sans savoir si je vais réussir de compléter
	le bonus dans le délai supposé (le test ne doit pas prendre 3 jours si j'ai bien compris).