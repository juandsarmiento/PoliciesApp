import React from 'react';
import { Alert } from 'reactstrap';

const ErrorAlert = ({ title = "Ups an unexpected error occurred", errors = {} }) => (
    <Alert color="danger">
        <h4 className="alert-heading">{title}</h4>
        {
            Object.values(errors).map(e => (
                <React.Fragment key={e}>
                    <hr></hr>
                    <p className="mb-0">{e}</p>
                </React.Fragment>))
        }
    </Alert>
)
export default ErrorAlert;