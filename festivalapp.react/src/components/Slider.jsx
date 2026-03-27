import {useState} from "react";

export const Slider = () => {
 
    const [slider, setSlider] = useState("test1.png");
    const [number, setNumber] = useState(1);

    const hedeleNumber = () => {
        setNumber(number+1);
        if(number == 5) setNumber(1)
    }

    setInterval(() => {setSlider(`test${number}.png`); hedeleNumber()}, 1000)
    return(<img src={slider} className="slider"/>)
}