import React, { Component } from 'react';
import axios from "axios";
import RemovePerson from './RemovePerson';

class PersonDetails extends Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <hr />
                <ul>
                    <li key={this.props.personName}> <b>Name: </b> {this.props.personName} </li>
                    <li key={this.props.id}> <b>ID: </b> {this.props.id} </li>
                    <li key={this.props.city}> <b>City: </b> {this.props.city} </li>
                    <li key={this.props.country}> <b>Country: </b> {this.props.country} </li>
                    <li key="language-list"> <b>Speaks: </b></li>
                    {this.props.ls?.map((element, i) => {
                        return <p key={i} >{element}</p>
                    })}
                    <RemovePerson personID={this.props.id} />
                </ul>

            </div>
        );
    }

}
export default PersonDetails;