import React, { Component } from 'react';
import axios from "axios";
import App from './App';
import ReactDOM from 'react-dom';

class RemovePerson extends Component {

    constructor(props) {
        super(props);
    }

    handleDelete = event => {
        event.preventDefault();

        console.log('personID: ' + this.props.personID);

        axios.post('/React/DeletePerson', null, { params: { id: this.props.personID} })
            .then(res => {
                console.log(res);
                console.log(res.data);
                ReactDOM.render('', document.querySelector("#details-container"));
                ReactDOM.render('', document.querySelector("#table-container"));
                ReactDOM.render(<App />, document.querySelector("#table-container"));
            })

    }

    render() {
        return (
            <div>
                <button onClick={this.handleDelete} style={{ color: "red" }} > Delete </button>
            </div>
        );
    }
}
export default RemovePerson;