# express-mongo-users-server

npm install -> copy .env.example to .env -> npm start.

POST /api/users/register - register a user (201 / 400 / 409)
GET /api/users/all - list users

Example body:
{
  "idNumber": "123456789",
  "fullName": "Israel Israeli",
  "email": "israel@example.com",
  "phone": "0501234567",
  "birthDate": "2000-05-20",
  "password": "Abcd1234!"
}
