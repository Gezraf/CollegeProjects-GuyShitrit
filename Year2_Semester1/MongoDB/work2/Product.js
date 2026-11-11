const mongoose = require('mongoose');

const CATEGORIES = ['מוצרי חלב', 'מאפייה', 'פירות וירקות', 'משקאות', 'בשר ודגים', 'חטיפים וממתקים', 'שימורים ומזווה', 'קפואים', 'ניקיון וטואלטיקה'];

const productSchema = new mongoose.Schema(
  {
    barcode: {
      type: String,
      required: [true, 'ברקוד הוא שדה חובה'],
      trim: true,
      unique: true,
      validate: {
        validator: (val) => /^\d{8,14}$/.test(val),
        message: 'הברקוד חייב להכיל בין 8 ל-14 ספרות בלבד'
      }
    },
    name: {
      type: String,
      required: [true, 'שם המוצר הוא שדה חובה'],
      trim: true,
      minlength: [2, 'שם המוצר חייב להכיל לפחות 2 תווים'],
      maxlength: [100, 'שם המוצר יכול להכיל עד 100 תווים'],
      validate: {
        validator: (val) => val.trim().length > 0,
        message: 'שם המוצר לא יכול להכיל רווחים בלבד'
      }
    },
    description: {
      type: String,
      trim: true,
      maxlength: [500, 'התיאור יכול להכיל עד 500 תווים'],
      default: 'אין תיאור זמין עבור מוצר זה',
      validate: {
        validator: (val) => val.length <= 500,
        message: 'אורך התיאור לא יכול לחרוג מ-500 תווים'
      }
    },
    price: {
      type: Number,
      required: [true, 'מחיר הוא שדה חובה'],
      min: [0.01, 'המחיר חייב להיות לפחות 0.01'],
      validate: {
        validator: (val) =>
          Number.isFinite(val) && val > 0 &&
          Math.abs(val * 100 - Math.round(val * 100)) < 1e-6,
        message: 'המחיר חייב להיות מספר חיובי עם עד 2 ספרות אחרי הנקודה'
      }
    },
    category: {
      type: String,
      required: [true, 'קטגוריה היא שדה חובה'],
      trim: true,
      enum: {
        values: CATEGORIES,
        message: 'אינה מורשית {VALUE} הקטגוריה'
      },
      validate: {
        validator: (val) => CATEGORIES.includes(val),
        message: 'הקטגוריה חייבת להיות אחת מהמחלקות המורשות'
      }
    },
    stockQuantity: {
      type: Number,
      required: [true, 'כמות במלאי היא שדה חובה'],
      default: 0,
      min: [0, 'הכמות במלאי לא יכולה להיות שלילית'],
      validate: {
        validator: Number.isInteger,
        message: 'הכמות במלאי חייבת להיות מספר שלם'
      }
    },
    unit: {
      type: String,
      required: [true, 'יחידת מידה היא שדה חובה'],
      default: 'יחידה',
      enum: {
        values: ['יחידה', 'ק"ג', 'גרם', 'ליטר', 'מארז'],
        message: 'יחידת המידה {VALUE} אינה מורשית'
      }
    },
    expiryDate: {
      type: Date,
      validate: {
        validator: (val) => !val || val.getTime() > Date.now(),
        message: 'תאריך התפוגה חייב להיות עתידי'
      }
    },
    isKosher: {
      type: Boolean,
      default: true,
      required: [true, 'יש לציין אם המוצר כשר']
    },
    discountPercentage: {
      type: Number,
      default: 0,
      min: [0, 'אחוז ההנחה לא יכול להיות שלילי'],
      max: [100, 'אחוז ההנחה לא יכול לעלות על 100'],
      validate: {
        validator: (val) => val >= 0 && val <= 100,
        message: 'אחוז ההנחה חייב להיות בין 0 ל-100'
      }
    }
  },
  {
    timestamps: true
  }
);

const Product = mongoose.model('SupermarketProduct', productSchema);
module.exports = Product;
