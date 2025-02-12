Aitana Rabasco Mora

P1 - La opción -n en el comando git revert se refiere a --no-commit, entonces al ejecutar esta opción tendrás que hacer tú el commit de manera manual mas tarde.
P2 - Elimina los cambios producidos volviendo al commit anterior.
P3 - La diferencia principal entre estos dos es que revert crea un nuevo commit, sin eliminar los commits anterior y reset si que elimina los commits y vuelve al commit anterior.
P4 - La diferencia principal entre ambos es que git merge combina el historial de las dos ramas en un nuevo commit, sin embargo rebase mueve los commits de una rama sobre otra, sobreescribiendola.