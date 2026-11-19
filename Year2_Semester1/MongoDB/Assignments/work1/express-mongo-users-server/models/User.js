const mongoose = require('mongoose');

const userSchema = new mongoose.Schema({
  idNumber: {
    type: String,
    required: true,
    unique: true,
    trim: true,
    match: [/^\d{9}$/, 'idNumber must be exactly 9 digits'],
  },
  fullName: {
    type: String,
    required: true,
    trim: true,
    minlength: 2,
    maxlength: 50,
    match: [/^[A-Za-zא-ת ]+$/, 'fullName can contain only Hebrew/English letters and spaces'],
  },
  email: {
    type: String,
    required: true,
    unique: true,
    trim: true,
    lowercase: true,
    match: [/^[^\s@]+@[^\s@]+\.[^\s@]+$/, 'email is not valid'],
  },
  phone: {
    type: String,
    required: true,
    trim: true,
    match: [/^05\d{8}$/, 'phone must be 10 digits and start with 05'],
  },
  birthDate: {
    type: Date,
    required: true,
    validate: {
      validator: (d) => {
        const oldest = new Date();
        oldest.setFullYear(oldest.getFullYear() - 120);
        return d <= new Date() && d >= oldest;
      },
      message: 'birthDate must be in the past and not older than 120 years',
    },
  },
  password: {
    type: String,
    required: true,
    minlength: 8,
    match: [
      /^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9]).+$/,
      'password needs an uppercase letter, a lowercase letter, a digit and a special character',
    ],
  },
});

userSchema.set('toJSON', {
  transform: (doc, ret) => {
    delete ret.password;
    return ret;
  },
});

module.exports = mongoose.model('User', userSchema);
