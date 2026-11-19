# express-mongo-crud-api

npm install, copy .env.example to .env, then npm start.

GET    /api/users            - all users (200)
GET    /api/users/:idNumber  - one user (200 / 404)
POST   /api/users            - create user (201 / 400 / 409)
PUT    /api/users/:idNumber  - update user (200 / 400 / 404 / 409)
DELETE /api/users/:idNumber  - delete one user (200 / 404)
DELETE /api/users            - delete all users (200)
