******* MIGRATIONS *******

1. enable-migrations - включити міграції.
2. add-migration (назва міграції) -project (проект з бд) - додати нову міграцію, наприклад: add-migration Initial -project DataAccessLogic
3. update-database - обновити базу даних.

******* BOOTSTRAP *******
---------------------------------------------------------------------------------
|
| 1. npm install bootstrap --save,  встановлення bootstrap
|
| 2. npm install jquery --save, встановлення jquery
| 
| 3. npm install popper.js --save, встановлення popper
|
| Підключення в json
| angular.json:
|
|    "styles": [   
|        "node_modules/bootstrap/dist/css/bootstrap.min.css",
|        "styles.css"
|      ],
|      "scripts": [  
|        "node_modules/jquery/dist/jquery.min.js",
|        "node_modules/popper.js/dist/umd/popper.min.js",
|        "node_modules/bootstrap/dist/js/bootstrap.min.js"
|      ],
---------------------------------------------------------------------------------