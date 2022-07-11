import React, { Component } from 'react';
import axios from "axios";
import App from './App';
import ReactDOM from 'react-dom';

class CreatePersonForm extends Component {
    state = {
        isLoading: true,
        name: '',
        cityID: '',
        number: '', 
        citiesList: ''
    };

    getCities = async () => {
        console.log("getting");
        await axios.post('/React/GetCities') // Get lsit of cities for drop-down menu
            .then(res => {
                // Sort them alphabetically
                this.state.citiesList = res.data
                    .sort(function (a, b) {
                        if (a.name.toLowerCase() < b.name.toLowerCase()) return -1;
                        if (a.name.toLowerCase() > b.name.toLowerCase()) return 1;
                        return 0;
                    });
                this.state.citiesList.map(c => console.log(c));
                this.state.isLoading = false;
                this.forceUpdate();
            })
    }

    handleSubmit = event => {
        event.preventDefault();

        // Check to see if the fields with no default-value are entered
        if (document.querySelector("#nameField").value != "" && document.querySelector("#numberField").value != "") {
            axios.post('/React/CreatePerson', null, { params: { name: this.state.name, cityID: this.state.cityID, number: this.state.number } })
                .then(res => {
                    ReactDOM.render('', document.querySelector("#table-container"));
                    ReactDOM.render(<App />, document.querySelector("#table-container"));

                    document.querySelector("#nameField").value = "";
                    //document.querySelector("#cityField").value = "";
                    document.querySelector("#numberField").value = "";
                });
        }
        else {
            alert("Please fill out all fields");
        }


    }
    handleNameChange = event => {
        this.setState({
            name: event.target.value,
        });
    }
    handleCityChange = event => {
        this.setState({
            cityID: event.target.value,
        });
    }
    handleNumberChange = event => {
        this.setState({
            number: event.target.value
        });
    }

    // Require the axios request to resolve before rendering component
    // getCities will a rerender once resolved
    render() {
        if (this.state.isLoading) {
            { this.getCities() }
            return <div>Loading...</div>
        }
        else {
            return (
                <div>
                    <hr />
                    <form onSubmit={this.handleSubmit}>
                        <label> Person Name:
                            <input type="text" name="name" id="nameField" onChange={this.handleNameChange} />
                        </label>
                        <label> City:
                            <select onChange={this.handleCityChange}>
                                { // Load city options
                                    this.state.citiesList.map((o, i) => (
                                        <option key={i} value={o.id}>{o.name}</option>
                                ))}
                            </select>
                        </label>
                        <label> Person Name:
                            <input type="text" name="number" id="numberField" onChange={this.handleNumberChange} />
                        </label>
                        <button type="submit"> Add </button>
                    </form>
                </div>
            );}
    }
}
export default CreatePersonForm;