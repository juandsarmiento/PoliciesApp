import React from 'react';
import ReactLoading from 'react-loading'
import { Container } from 'reactstrap';
import './assets/css/Loading.css'

const Loading = () => (
    <Container id='loadingContainer' fluid={true}>
        <ReactLoading type='bars' color='black' />
    </Container>
)
export default Loading;