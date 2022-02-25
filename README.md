# Rapport du projet tests unitaires :

# 1 / Architecture & outils utilisé :
* Le projet contient 3 projets integrés, le projet  API contient les models/controllers ainsi que la migration de la base de donnée et le projet Test contient toutes les tests unitaire/intégrations du projet dans la class : CustomerController. 

![image](https://user-images.githubusercontent.com/61312131/155693015-eb0ee98b-d449-4b71-909b-432b6cf8c8e7.png)

* Nunit est l'outil le plus connu pour la plateforme dotnet, et est un produit gratuit sous licence open source, pour effectué des testes.
* Utilisation de l'ORM ENTITY FRAMEWORK pour intéragir ave la base donnée.

![image](https://user-images.githubusercontent.com/61312131/155690013-8a63671b-ce70-4053-bf77-b8e0694604aa.png)

# 2 / Tests passé & Approche TDD :
* Nombre des testes intégré dans le projet  : 

![image](https://user-images.githubusercontent.com/61312131/155695403-2272fe85-f37b-4d1b-ae66-83acce539240.png)


* Le développement piloté par les tests (TDD) est une approche de développement logiciel avec laquelle des cas de test sont développés avant de créer le code lui même.

![image](https://user-images.githubusercontent.com/61312131/155694323-5b1d2e27-7794-485a-aa10-400fdc14f5dd.png)

-->   Utilisation de l'approche TDD dans un test paramétré lié à la classe HOMETEST:

![image](https://user-images.githubusercontent.com/61312131/155694743-b8f185a2-f5c9-460e-bb00-80a5fc4fa814.png)

# 3 / Tests unitaires :
Afin d'intégré des tests unitaires on a utilisé des réglés metiers dans notre model CUSTOMER sur ses champs, Afin de assurer que l'utilisateur ne peut violer ces règles métiers il est également important de les tester (champ par champ).

![image](https://user-images.githubusercontent.com/61312131/155696335-be43079b-e983-4715-a88d-7d9d8a4f3a7e.png)

* Tests unitaires totale de la classe customer : 

![image](https://user-images.githubusercontent.com/61312131/155702027-afa15589-cd3e-4bd1-8f38-ba7ef5364555.png)

# 4 / Tests d'intégrations sur le CRUD :

* On a implimenter deux tests d'intégrations pour le GetByID et GetAll, en utilisant notre controller 'BaseController' qui contients nos opearations de CRUD.

![image](https://user-images.githubusercontent.com/61312131/155703713-7b40f7b4-4a44-4815-b2ad-be0aaf5fbd08.png)

# 5 / La couverture du code 'CODE COVERAGE' : 

![image](https://user-images.githubusercontent.com/61312131/155704027-05e77e7e-df68-4369-aabe-d29266eef2ae.png)

* Puisque on a fait des tests d'intégration sur l'ensemble de notre classe Customers (sur ces champs / contrôle de saisie), le code coverage montre que notre model CUSTOMER est testé 100%.

![image](https://user-images.githubusercontent.com/61312131/155704158-b0bd91fb-9377-4130-b836-c2bac3328d64.png)

# 6 / Importance des tests dans une application / Ce que j'ai appris ? 
Un test permet de tester le bon fonctionnement d'une partie précise d'un programme. Il permet de s'assurer que le comportement d'une application est correct.

* Les tests unitaires, qui doivent être petits, rapides et très ciblés. Ils permettent de détecter les erreurs au plus tôt. La majorité des composants sont simulés, ce qui implique qu'ils ne représentent pas forcément la réalité. Ils ont l'avantage de pouvoir s'exécuter sur l'ordinateur du développeur, ce qui permet de les passer très rapidement 

* Les tests d'intégration, qui permettent de tester plusieurs composants. Certains sont simulés, d'autres sont réels. Ils peuvent s'exécuter sur l'émulateur ou sur un équipement réel.
