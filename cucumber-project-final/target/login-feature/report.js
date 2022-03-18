$(document).ready(function() {var formatter = new CucumberHTML.DOMFormatter($('.cucumber-report'));formatter.uri("uni/fmi/del/del.feature");
formatter.feature({
  "line": 1,
  "name": "Изтриване на тема.",
  "description": "",
  "id": "изтриване-на-тема.",
  "keyword": "Feature"
});
formatter.scenario({
  "line": 3,
  "name": "Изтриване на тема от форума.",
  "description": "",
  "id": "изтриване-на-тема.;изтриване-на-тема-от-форума.",
  "type": "scenario",
  "keyword": "Scenario"
});
formatter.step({
  "line": 4,
  "name": "Статус на потребител: \"Admin\"",
  "keyword": "Given "
});
formatter.step({
  "line": 5,
  "name": "Намиране на търсената тема.",
  "keyword": "When "
});
formatter.step({
  "line": 6,
  "name": "Вижда бутон \"Изтрий\".",
  "keyword": "And "
});
formatter.step({
  "line": 7,
  "name": "Натискане на бутон \"Изтрий\".",
  "keyword": "And "
});
formatter.step({
  "line": 8,
  "name": "Вижда съобщение за успешно изтриване.",
  "keyword": "Then "
});
formatter.match({
  "arguments": [
    {
      "val": "Admin",
      "offset": 23
    }
  ],
  "location": "DelSteps.статус_на_потребител(String)"
});
formatter.result({
  "duration": 213881300,
  "error_message": "cucumber.api.PendingException: TODO: implement me\r\n\tat uni.fmi.del.DelSteps.статус_на_потребител(DelSteps.java:12)\r\n\tat ✽.Given Статус на потребител: \"Admin\"(uni/fmi/del/del.feature:4)\r\n",
  "status": "pending"
});
formatter.match({
  "location": "DelSteps.намиране_на_търсената_тема()"
});
formatter.result({
  "status": "skipped"
});
formatter.match({
  "arguments": [
    {
      "val": "Изтрий",
      "offset": 13
    }
  ],
  "location": "DelSteps.вижда_бутон(String)"
});
formatter.result({
  "status": "skipped"
});
formatter.match({
  "arguments": [
    {
      "val": "Изтрий",
      "offset": 20
    }
  ],
  "location": "DelSteps.натискане_на_бутон(String)"
});
formatter.result({
  "status": "skipped"
});
formatter.match({
  "location": "DelSteps.вижда_съобщение_за_успешно_изтриване()"
});
formatter.result({
  "status": "skipped"
});
});