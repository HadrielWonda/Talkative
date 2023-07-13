# Api

- [Api] {#api}
  - [Message] {#message}
     -[CreateMessageRequest]{#create-message-request}
     -[CreateMessageResponse]{#create-message-response}

## Message

### Create Message request


```js
 POST /api/talks/{talkId}/messages
 POST /api/talks
```


```json
{
"talkId":"000000000-0000-0000-0000-00000000000000000",
"textContent" : "string",
"createdBy" : "000000000-0000-0000-0000-00000000000000000",
"secondParty" : "000000000-0000-0000-0000-00000000000000000"
}
```

### Create message response



```json
{
"id": "000000000-0000-0000-0000-00000000000000000",
"textContent" : "string",
"createdBy" : "000000000-0000-0000-0000-00000000000000000",
"secondParty" : "000000000-0000-0000-0000-00000000000000000",
"createdDateTime" : "2023-07-09T00:00:00002"


}
```