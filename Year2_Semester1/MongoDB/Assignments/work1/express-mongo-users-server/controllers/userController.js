const User = require('../models/User');

const createUser = async (req, res) => {
  try {
    const { idNumber, fullName, email, phone, birthDate, password } = req.body;
    const user = await User.create({ idNumber, fullName, email, phone, birthDate, password });
    res.status(201).json({ message: 'User created', user });
  } catch (err) {
    if (err.name === 'ValidationError') {
      const errors = Object.values(err.errors).map((e) => e.message);
      return res.status(400).json({ message: 'Validation failed', errors });
    }
    if (err.code === 11000) {
      const field = Object.keys(err.keyPattern)[0];
      return res.status(409).json({ message: `${field} already exists` });
    }
    res.status(500).json({ message: 'Server error' });
  }
};

const getAllUsers = async (req, res) => {
  try {
    res.json(await User.find());
  } catch (err) {
    res.status(500).json({ message: 'Server error' });
  }
};

module.exports = { createUser, getAllUsers };
