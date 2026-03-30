export const UserCard = (props) => {
    return(
        <div className="card">
            <span>{props.user.id}</span>
            <span>{props.user.name}</span>
        </div>
    );
};