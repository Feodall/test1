import {Slider} from "../components/Slider"
import { useEffect, useState } from "react";
import axios from "axios";
import {UserCard} from "./UserCard";

export const Home = () => {

    const [users, setUsers] = useState([]);

    const getUsers = async () => {
    
        var response = await axios.get("http://localhost:5142/api/Users");
        console.log(response);
        setUsers(response.data);
    };

    useEffect(() => {getUsers();}, []);

    return(
        
    <div>
        <h1>Список пользователей</h1>
        <ul>
            {users.map((u) => (
                <UserCard user={u} key={u.id}/>
            ))}
        </ul>
        <p className="start">
            До начала фестиваля осталось:<span className="days"> 6 дней </span></p>
        <Slider/>
        {/* <p className="text">Lorem ipsum dolor sit amet consectetur adipisicing elit. Commodi voluptatum molestias ab doloremque incidunt maxime aliquam dolorem eius eligendi labore, perspiciatis, vitae nemo quod libero itaque inventore asperiores enim ipsam dicta eum. Vitae soluta nostrum fugiat, dignissimos minima culpa repudiandae. Incidunt, quasi doloremque temporibus id corrupti repellat earum, dolorem sed veniam exercitationem sequi hic? Quas sit aut rerum quibusdam aperiam eum reiciendis facere minima deleniti. Amet nemo tenetur deserunt asperiores, mollitia magnam doloremque? Nobis debitis, fugiat unde harum reiciendis, placeat, nesciunt laborum corrupti minima sed cum voluptate voluptas! Cupiditate excepturi similique nemo officia, maxime ab fugit labore minus doloribus ducimus!</p> */}
        </div>
    )
}