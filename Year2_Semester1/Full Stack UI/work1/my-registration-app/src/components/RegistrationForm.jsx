import { useState } from 'react';

const emptyForm = {
  fullName: '',
  email: '',
  password: '',
  confirmPassword: '',
  age: '',
  idNumber: '',
};

function RegistrationForm({ onRegister }) {
  const [form, setForm] = useState(emptyForm);
  const [errors, setErrors] = useState({});

  const handleChange = (e) => {
    // אובייקט חדש בכל שינוי
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const validate = () => {
    const newErrors = {};
    if (form.fullName.trim() === '') {
      newErrors.fullName = 'נא להזין שם מלא';
    }
    if (!form.email.includes('@')) {
      newErrors.email = 'כתובת אימייל לא תקינה';
    }
    if (form.password.length < 6) {
      newErrors.password = 'הסיסמה חייבת להכיל לפחות 6 תווים';
    }
    if (form.password !== form.confirmPassword) {
      newErrors.confirmPassword = 'הסיסמאות אינן תואמות';
    }
    if (form.age < 1 || form.age > 120) {
      newErrors.age = 'נא להזין גיל תקין';
    }
    if (form.idNumber.length !== 9) {
      newErrors.idNumber = 'נדרשות 9 ספרות';
    }
    return newErrors;
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const newErrors = validate();
    setErrors(newErrors);
    if (Object.keys(newErrors).length > 0) {
      return;
    }

    alert(
      `שם מלא: ${form.fullName}\n` +
        `אימייל: ${form.email}\n` +
        `סיסמה: ${form.password}\n` +
        `גיל: ${form.age}\n` +
        `תעודת זהות: ${form.idNumber}`
    );

    onRegister(form);
    setForm(emptyForm);
  };

  return (
    <form className="registration-form" onSubmit={handleSubmit} noValidate>
      <h2>יצירת חשבון חדש</h2>
      <p className="subtitle">אנא מלאו את הפרטים מטה כדי להירשם לשירות</p>

      <div className={errors.fullName ? 'form-group invalid' : 'form-group'}>
        <label htmlFor="fullName">שם מלא</label>
        <input id="fullName" name="fullName" type="text" value={form.fullName} onChange={handleChange} />
        {errors.fullName && <p className="hint">{errors.fullName}</p>}
      </div>

      <div className={errors.email ? 'form-group invalid' : 'form-group'}>
        <label htmlFor="email">כתובת אימייל</label>
        <input id="email" name="email" type="email" value={form.email} onChange={handleChange} />
        {errors.email && <p className="hint">{errors.email}</p>}
      </div>

      <div className={errors.password ? 'form-group invalid' : 'form-group'}>
        <label htmlFor="password">סיסמה</label>
        <input id="password" name="password" type="password" value={form.password} onChange={handleChange} />
        {errors.password && <p className="hint">{errors.password}</p>}
      </div>

      <div className={errors.confirmPassword ? 'form-group invalid' : 'form-group'}>
        <label htmlFor="confirmPassword">אימות סיסמה</label>
        <input
          id="confirmPassword"
          name="confirmPassword"
          type="password"
          value={form.confirmPassword}
          onChange={handleChange}
        />
        {errors.confirmPassword && <p className="hint">{errors.confirmPassword}</p>}
      </div>

      <div className={errors.age ? 'form-group invalid' : 'form-group'}>
        <label htmlFor="age">גיל</label>
        <input id="age" name="age" type="number" value={form.age} onChange={handleChange} />
        {errors.age && <p className="hint">{errors.age}</p>}
      </div>

      <div className={errors.idNumber ? 'form-group invalid' : 'form-group'}>
        <label htmlFor="idNumber">מספר תעודת זהות</label>
        <input id="idNumber" name="idNumber" type="text" maxLength={9} value={form.idNumber} onChange={handleChange} />
        {errors.idNumber && <p className="hint">{errors.idNumber}</p>}
      </div>

      <button type="submit" className="submit-btn">
        הרשמה
      </button>
      <p className="login-link">
        כבר רשומים? <a href="#login">להתחברות</a>
      </p>
    </form>
  );
}

export default RegistrationForm;
