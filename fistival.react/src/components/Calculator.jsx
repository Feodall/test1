import { useState } from "react";

export const Calculator = () => {

  const [test, setTest] = useState();
  const [per, setPer] = useState();
  const [result, setResult] = useState();

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log("form sabmit");
  };

  const conteiner = () => {
    setTest("");
    setPer("");
    setResult("")
  };

  const plus = () => {
    setResult(() => Number(test) + Number(per))
  }

  const multiply = () => {
    setResult(() => Number(test ) * Number(per))
  }

  const devide = ()  =>{
    setResult(() => Number(test) / Number(per))
  }

  const deffence = () => {
    setResult(() => Number(test) - Number(per))
  }

  
  return (
    <div>

      <form className="calc" onSubmit={handleSubmit}>
        <input
          type="text"
          name="test"
          value={test}
          placeholder="Первое число"
          onChange={(e) => setTest(e.target.value)}
        />

        <input
          type="text"
          name="per"
          value={per}
          placeholder="Второе число число"
          onChange={(e) => setPer(e.target.value)}
        />

        <input
          type="text"
          name="result"
          value={result}
          placeholder="Результат"
        />
        

        
        
        <button onClick={() => conteiner()}>Press to clean</button>
        <button onClick={() => plus()}>Plus</button>
        <button onClick={() => multiply()}>Multiply</button>
        <button onClick={() => devide()}>Devide</button>
        <button onClick={() => deffence()}>Deffence</button>
      </form>
    </div>
  );
};
