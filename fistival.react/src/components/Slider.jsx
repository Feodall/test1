import { useState } from "react";

export const Slider = () => {

const [slider, setSlider] = useState("test4.png"); 
const [number, setNumber] = useState(1)


const handleNumber = () => {
   setNumber(number+1);
   if(number == 4) setNumber(1)
}


setInterval(() => {setSlider(`test${number}.png`); handleNumber()},2000)

    
 return( <div> <h1>eefsfesf</h1>
    <img src={slider}/>
    {/* <button onClick={()=>{setSlider("test2.png")}}>Press to slide</button> */}
  </div>
)
};