const express = require('express');
const { createUser, getAllUsers } = require('../controllers/userController');

const router = express.Router();

router.post('/', createUser);
router.post('/register', createUser);
router.get('/all', getAllUsers);

module.exports = router;
