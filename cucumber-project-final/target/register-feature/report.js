$(document).ready(function() {var formatter = new CucumberHTML.DOMFormatter($('.cucumber-report'));formatter.uri("uni/fmi/register/register.feature");
formatter.feature({
  "line": 1,
  "name": "Регистрация на потребител",
  "description": "",
  "id": "регистрация-на-потребител",
  "keyword": "Feature"
});
formatter.scenarioOutline({
  "line": 3,
  "name": "Регистрация на потребител",
  "description": "",
  "id": "регистрация-на-потребител;регистрация-на-потребител",
  "type": "scenario_outline",
  "keyword": "Scenario Outline"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за регистрация на нов потребител",
  "keyword": "Given "
});
formatter.step({
  "line": 5,
  "name": "Въведе потребителско име: \"\u003cпотребителско име\u003e\"",
  "keyword": "When "
});
formatter.step({
  "line": 6,
  "name": "Въведе парола: \"\u003cпарола\u003e\"",
  "keyword": "And "
});
formatter.step({
  "line": 7,
  "name": "Въведе повторно парола: \"\u003cпарола2\u003e\"",
  "keyword": "And "
});
formatter.step({
  "line": 8,
  "name": "Въведе електронна поща: \"\u003cemail\u003e\"",
  "keyword": "And "
});
formatter.step({
  "line": 9,
  "name": "Натисне бутона за регистрация",
  "keyword": "And "
});
formatter.step({
  "line": 10,
  "name": "Вижда съобщение \"\u003cСъобщение\u003e\"",
  "keyword": "Then "
});
formatter.examples({
  "line": 12,
  "name": "",
  "description": "",
  "id": "регистрация-на-потребител;регистрация-на-потребител;",
  "rows": [
    {
      "cells": [
        "потребителско име",
        "парола",
        "парола2",
        "email",
        "Съобщение"
      ],
      "line": 13,
      "id": "регистрация-на-потребител;регистрация-на-потребител;;1"
    },
    {
      "cells": [
        "Реджеп",
        "redzhep00",
        "redzhep00",
        "redjep@abv.bg",
        "Успешна регистрация"
      ],
      "line": 15,
      "id": "регистрация-на-потребител;регистрация-на-потребител;;2"
    },
    {
      "cells": [
        "Реджеп",
        "redzhep00",
        "redzhep",
        "redjep@abv.bg",
        "Въведете еднакви пароли"
      ],
      "line": 16,
      "id": "регистрация-на-потребител;регистрация-на-потребител;;3"
    },
    {
      "cells": [
        "",
        "redzhep00",
        "redzhep00",
        "redjep@abv.bg",
        "Въведете име"
      ],
      "line": 17,
      "id": "регистрация-на-потребител;регистрация-на-потребител;;4"
    }
  ],
  "keyword": "Examples"
});
formatter.scenario({
  "line": 15,
  "name": "Регистрация на потребител",
  "description": "",
  "id": "регистрация-на-потребител;регистрация-на-потребител;;2",
  "type": "scenario",
  "keyword": "Scenario Outline"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за регистрация на нов потребител",
  "keyword": "Given "
});
formatter.step({
  "line": 5,
  "name": "Въведе потребителско име: \"Реджеп\"",
  "matchedColumns": [
    0
  ],
  "keyword": "When "
});
formatter.step({
  "line": 6,
  "name": "Въведе парола: \"redzhep00\"",
  "matchedColumns": [
    1
  ],
  "keyword": "And "
});
formatter.step({
  "line": 7,
  "name": "Въведе повторно парола: \"redzhep00\"",
  "matchedColumns": [
    2
  ],
  "keyword": "And "
});
formatter.step({
  "line": 8,
  "name": "Въведе електронна поща: \"redjep@abv.bg\"",
  "matchedColumns": [
    3
  ],
  "keyword": "And "
});
formatter.step({
  "line": 9,
  "name": "Натисне бутона за регистрация",
  "keyword": "And "
});
formatter.step({
  "line": 10,
  "name": "Вижда съобщение \"Успешна регистрация\"",
  "matchedColumns": [
    4
  ],
  "keyword": "Then "
});
formatter.match({
  "location": "RegisterSteps.openRegisterScreen()"
});
formatter.result({
  "duration": 3601300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Реджеп",
      "offset": 27
    }
  ],
  "location": "RegisterSteps.addUsername(String)"
});
formatter.result({
  "duration": 297300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redzhep00",
      "offset": 16
    }
  ],
  "location": "RegisterSteps.addFirstPass(String)"
});
formatter.result({
  "duration": 148800,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redzhep00",
      "offset": 25
    }
  ],
  "location": "RegisterSteps.addSecondPass(String)"
});
formatter.result({
  "duration": 224000,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redjep@abv.bg",
      "offset": 25
    }
  ],
  "location": "RegisterSteps.addEmail(String)"
});
formatter.result({
  "duration": 98800,
  "status": "passed"
});
formatter.match({
  "location": "RegisterSteps.clickRegisterButton()"
});
formatter.result({
  "duration": 84300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Успешна регистрация",
      "offset": 17
    }
  ],
  "location": "RegisterSteps.checkMessage(String)"
});
formatter.result({
  "duration": 132900,
  "status": "passed"
});
formatter.scenario({
  "line": 16,
  "name": "Регистрация на потребител",
  "description": "",
  "id": "регистрация-на-потребител;регистрация-на-потребител;;3",
  "type": "scenario",
  "keyword": "Scenario Outline"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за регистрация на нов потребител",
  "keyword": "Given "
});
formatter.step({
  "line": 5,
  "name": "Въведе потребителско име: \"Реджеп\"",
  "matchedColumns": [
    0
  ],
  "keyword": "When "
});
formatter.step({
  "line": 6,
  "name": "Въведе парола: \"redzhep00\"",
  "matchedColumns": [
    1
  ],
  "keyword": "And "
});
formatter.step({
  "line": 7,
  "name": "Въведе повторно парола: \"redzhep\"",
  "matchedColumns": [
    2
  ],
  "keyword": "And "
});
formatter.step({
  "line": 8,
  "name": "Въведе електронна поща: \"redjep@abv.bg\"",
  "matchedColumns": [
    3
  ],
  "keyword": "And "
});
formatter.step({
  "line": 9,
  "name": "Натисне бутона за регистрация",
  "keyword": "And "
});
formatter.step({
  "line": 10,
  "name": "Вижда съобщение \"Въведете еднакви пароли\"",
  "matchedColumns": [
    4
  ],
  "keyword": "Then "
});
formatter.match({
  "location": "RegisterSteps.openRegisterScreen()"
});
formatter.result({
  "duration": 104500,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Реджеп",
      "offset": 27
    }
  ],
  "location": "RegisterSteps.addUsername(String)"
});
formatter.result({
  "duration": 81100,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redzhep00",
      "offset": 16
    }
  ],
  "location": "RegisterSteps.addFirstPass(String)"
});
formatter.result({
  "duration": 85100,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redzhep",
      "offset": 25
    }
  ],
  "location": "RegisterSteps.addSecondPass(String)"
});
formatter.result({
  "duration": 92500,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redjep@abv.bg",
      "offset": 25
    }
  ],
  "location": "RegisterSteps.addEmail(String)"
});
formatter.result({
  "duration": 69700,
  "status": "passed"
});
formatter.match({
  "location": "RegisterSteps.clickRegisterButton()"
});
formatter.result({
  "duration": 38400,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Въведете еднакви пароли",
      "offset": 17
    }
  ],
  "location": "RegisterSteps.checkMessage(String)"
});
formatter.result({
  "duration": 84300,
  "status": "passed"
});
formatter.scenario({
  "line": 17,
  "name": "Регистрация на потребител",
  "description": "",
  "id": "регистрация-на-потребител;регистрация-на-потребител;;4",
  "type": "scenario",
  "keyword": "Scenario Outline"
});
formatter.step({
  "line": 4,
  "name": "Потребителят отваря екрана за регистрация на нов потребител",
  "keyword": "Given "
});
formatter.step({
  "line": 5,
  "name": "Въведе потребителско име: \"\"",
  "matchedColumns": [
    0
  ],
  "keyword": "When "
});
formatter.step({
  "line": 6,
  "name": "Въведе парола: \"redzhep00\"",
  "matchedColumns": [
    1
  ],
  "keyword": "And "
});
formatter.step({
  "line": 7,
  "name": "Въведе повторно парола: \"redzhep00\"",
  "matchedColumns": [
    2
  ],
  "keyword": "And "
});
formatter.step({
  "line": 8,
  "name": "Въведе електронна поща: \"redjep@abv.bg\"",
  "matchedColumns": [
    3
  ],
  "keyword": "And "
});
formatter.step({
  "line": 9,
  "name": "Натисне бутона за регистрация",
  "keyword": "And "
});
formatter.step({
  "line": 10,
  "name": "Вижда съобщение \"Въведете име\"",
  "matchedColumns": [
    4
  ],
  "keyword": "Then "
});
formatter.match({
  "location": "RegisterSteps.openRegisterScreen()"
});
formatter.result({
  "duration": 138900,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "",
      "offset": 27
    }
  ],
  "location": "RegisterSteps.addUsername(String)"
});
formatter.result({
  "duration": 124300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redzhep00",
      "offset": 16
    }
  ],
  "location": "RegisterSteps.addFirstPass(String)"
});
formatter.result({
  "duration": 533200,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redzhep00",
      "offset": 25
    }
  ],
  "location": "RegisterSteps.addSecondPass(String)"
});
formatter.result({
  "duration": 50300,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "redjep@abv.bg",
      "offset": 25
    }
  ],
  "location": "RegisterSteps.addEmail(String)"
});
formatter.result({
  "duration": 42800,
  "status": "passed"
});
formatter.match({
  "location": "RegisterSteps.clickRegisterButton()"
});
formatter.result({
  "duration": 23600,
  "status": "passed"
});
formatter.match({
  "arguments": [
    {
      "val": "Въведете име",
      "offset": 17
    }
  ],
  "location": "RegisterSteps.checkMessage(String)"
});
formatter.result({
  "duration": 72100,
  "status": "passed"
});
});