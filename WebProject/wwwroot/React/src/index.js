import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import ImageUpload from './ImageUpload';
import CreatePersonForm from './CreatePersonForm';
ReactDOM.render(
    <React.Fragment>
        {/*<CreatePersonForm />
        <div id="details-container"> </div>
        <div id="table-container"> <App /> </div>*/}

        {<div id="upload-container"><ImageUpload /></div>}
    </React.Fragment>,
    document.getElementById('root')
);