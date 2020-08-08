import React from 'react';
import ReactDOM from 'react-dom';
import { connect } from 'react-redux';
import ErrorAlert from '../components/ErrorAlert';

const ErrorAlertContainer = ({error}) => {
    if (error === null) return '';
    return (
        ReactDOM.createPortal(
            <ErrorAlert {...error} />,
            document.getElementById('portal-root'))
    )
}

const mapState2Props = (state) => {
    const { policyState: { error } } = state;
    return {
        error
    }
}

export default connect(mapState2Props)(ErrorAlertContainer);

