


# Api

- [Api] {#api}
- [talk] {#talk}
  -[CreatetalkRequest]{#create-talk-request}
  -[CreatetalkResponse]{#create-talk-response}

## talk

### Create talk request


```js
 POST /api/talks
```


```json
{
"textContent" : "string",
"attachments" : {
    {
      "type" : "location"
    }
}
"createdBy" : 
"000000000-0000-0000-0000-00000000000000000",
"secondParty" : "000000000-0000-0000-0000-00000000000000000"
}
```

### Create talk response



```json
{
"id": "000000000-0000-0000-0000-00000000000000000",
"textContent" : "string",
"createdBy" : 
"000000000-0000-0000-0000-00000000000000000",
"secondParty" : "000000000-0000-0000-0000-00000000000000000",
"createdDateTime" : "2023-07-09T00:00:00002"


}
```
