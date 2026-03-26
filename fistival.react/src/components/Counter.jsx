import { useState } from "react";

export const Counter = () => {

  const [login, setLogin] = useState();
  const [password, setPassword] = useState();

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log("form submit");
  };

  const clearForm = () => {
    setLogin("");
    setPassword("");
  }

  return (
    <div>
      <form className="form" onSubmit={handleSubmit}>
        <label htmlFor="login" > Login</label>
        <input type="text" name="login" value={login} onChange={(e) => setLogin(e.target.value)} />

        <label htmlFor="password">Password</label>
        <input type="password" name="password" value={password} onChange={(e) => setPassword(e.target.value)} />

        <button onClick={() => clearForm()} >Press</button>
      </form>

      <span> Login: {login} </span>
      <span> Password: {password} </span>
    </div>
  );
};
