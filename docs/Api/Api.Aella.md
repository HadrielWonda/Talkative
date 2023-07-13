# Api

- [Api] {#api}
  - [Message] {#message}
     -[CreateAellaMessageRequest]{#create-aella-message-request}
     -[CreateAellaMessageResponse]{#create-aella-message-response}

## Aella

### Create Aella Message Request {beta}


```js
 POST /api/beta/talks/{talkId}/aella/answers
```



```json
{
"textContent" : "Hey Aella.. perform string",
"createdBy" : "000000000-0000-0000-0000-00000000000000000"
}
```

### Create Aella Message Response {beta}



```json
{
"aellaText" : "Sure thing!! string",
"createdBy" : "000000000-0000-0000-0000-00000000000000000"
}
```

### Create Aella Message Request {V1}


```js
 POST /api/beta/talks/{talkId}/aella/messages
```



```json
{
"textContent" : "Hey Aella.. perform string",
"createdBy" : "000000000-0000-0000-0000-00000000000000000"
}
```

### Create Aella Message Response {v1}



```json
{
"id": "000000000-0000-0000-0000-00000000000000000",
"aellaText" : "Sure thing!! string",
"createdBy" : "000000000-0000-0000-0000-00000000000000000",
"createdDateTime" : "2023-07-09T00:00:00002"
}
```