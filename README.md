# React

для запуска нужна команда -

- npx create-vite@latest
- react
- javascript

# Migrations

- dotnet-ef migrations add NameMigrations

- dotnet-ef database update
- dotnet-ef databse drop

# Form Hadle

```js
<form className="form" onSubmit={handleSubmit}>
  <label htmlFor="login"> Login</label>
  <input
    type="text"
    name="login"
    value={login}
    onChange={(e) => setLogin(e.target.value)}
  />

  <label htmlFor="password">Password</label>
  <input
    type="password"
    name="password"
    value={password}
    onChange={(e) => setPassword(e.target.value)}
  />

  <button onClick={() => clearForm()}>Press</button>
</form>
```
