import { useState } from "react";

export const Card = () => {

  const [block, setBlock] = useState(false);

  return (
    <div className="card">
      <img src="test.png" className="center-img" />

      <button style={{width: "100px", margin: "1rem"}}  onClick={() => setBlock(!block)}> {block==true ? "Hide" : "Show"} </button>
      {

        block &&

        <span className="text-long">
          Lorem ipsum dolor sit amet consectetur, adipisicing elit. Facere
          aliquid deserunt doloribus molestiae animi hic, fugit rem vel ullam
          labore totam delectus. Reiciendis quia expedita eaque exercitationem
          quisquam possimus, libero dolor ab deserunt at aperiam provident!
          Alias quis consequatur quasi sit? Pariatur ipsa laborum itaque!
          Labore, ab dicta id eum doloremque ullam dolores, laudantium soluta
          placeat, distinctio cum sapiente ea aliquam consequuntur fugit
          numquam. Deleniti eius itaque placeat laborum velit perspiciatis nam
          dolorum distinctio hic, repellat dicta, rerum expedita ex accusantium
          ipsum quae consectetur molestias deserunt facilis pariatur optio,
          similique ut. Expedita, eaque architecto commodi quo repudiandae iusto
          doloribus quibusdam.
        </span>
        
      }
    </div>
  );
};
