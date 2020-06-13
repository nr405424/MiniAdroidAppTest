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

-	J'ai cr�� un nouveau projet dans Unity contenant deux boutons : un pour toast et un pour vibrate.
	Apr�s l'avoir export�, j'ai ensuite ouvert le projet dans Android Studio.

-	J'ai ensuite cr�� nouveau module "Android Library" (en java) dans Android Studio pour pouvoir
	r�cuperer un plugin .aar, et pour avoir une communication Java <> C#, j'ai d� copier le fichier
	unity-classes.jar pr�sent dans le dossier libs de mon projet et le coller dans celui de mon nouveau
	module, ce qui me permet d'acceder � UnityPlayer.

-	Mon fichier java contient deux m�thodes :
		-> une m�thode pour cr�er un toast message
		-> une m�thode pour faire vibrer le portable (en fonction de sa version d'API)

-	Apr�s avoir clean et build dans le gradle de mon module, j'ai mis le .aar g�n�r� dans le fichier
	Assets de mon projet Unity. Les m�thodes appel�es dans mon script C# par les boutons Toast et Vibrate
	font donc r�f�rence aux m�thodes de mon plugin .aar

COMPLICATIONS

-	L'installation du module Android Build Support + Android SDK & NDK Tools + OpenJDK pour Unity ainsi que
	l'installation du logiciel Android Studio ont pris �norm�ment de temps.

-	Android Studio impacte beaucoup la performance de mon ordinateur.

-	Des probl�mes d'espace d'ordinateur.

PROBLEMES RENCONTRES

-	Des incompatibilit�s entre les versions d'API et de SDK. J'ai d� t�l�charger des nouveaux SDK dans Android
	Studio pour avoir la m�me version utilis�e dans Unity.

-	Vu que Unity peut afficher ses propres toast messages, j'ai perdu un peu de temps � croire que mon fichier C#
	n'arrivait pas � utiliser mon plugin android car le toast message n'apparait pas dans la game view quand
	je clique sur le bouton toast. Le message n'apparassait pas non plus dans mon portable, qui est connect�
	avec le projet via Unity Remote 5. Par cons�quence, j'ai essay� plusieurs fois diff�rentes m�thodes pour
	afficher un toast via Android Studio. Apr�s quelques essais, j'ai decid� de faire un build et de le mettre
	directement dans mon portable, ce qui a march�. Je ne suis pas exactement certaine, je pense que peut-�tre
	Unity n'est pas capable d'afficher des contenus cr��s par Android Studio ?

-	Je n'�tais pas tr�s famil�re � la communication entre Java et C# en utilisant � la fois Unity et Android
	Studio, dont la necessit� pour moi de consacrer du temps � lire la documentation, faire des recherches, et
	faire des essaies et erreurs. Par exemple, je n'arrivais pas � g�n�rer un fichier .jar, ce qui m'a incit�
	d'essayer de g�n�rer un fichier .aar, ce qui semblait plus simple.

-	J'ai d�cid� de vous envoyer mon rendu sans le http callback car j'ai d�j� pass� du temps pour en arriver �
	ce r�sultat (1 journ�e / 2). Sachant que je vais prendre du temps � l'impl�menter, j'ai pr�f�r� vous envoyer
	un r�sultat fonctionnel que j'ai test�, plut�t que de tarder � rendre sans savoir si je vais r�ussir de compl�ter
	le bonus dans le d�lai suppos� (le test ne doit pas prendre 3 jours si j'ai bien compris).