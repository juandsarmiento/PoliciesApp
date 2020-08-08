
import axios from 'axios';
import { URL } from '../components/api-authorization/ApiAuthorizationConstants';

export const REQUEST_DATA = 'REQUEST_DATA';
export const RECEIVE_POLICIES = 'RECEIVE_POLICIES';
export const POLICY_CREATED = 'POLICY_CREATED';
export const SET_ERROR = 'SET_ERROR';
export const CLEAN_ERROR = 'CLEAN_ERROR';
export const RECEIVE_RISK_TYPES = 'RECEIVE_RISK_TYPES';
export const RECEIVE_COVERAGE_TYPES = 'RECEIVE_COVERAGE_TYPES';
export const RECEIVE_CLIENTS = 'RECEIVE_CLIENTS';

const normalizeData = (array, keyField) =>
    array.reduce((obj, item) => {
        obj[item[keyField]] = item
        return obj
    }, {})
const timeout = 5000;
//action creators
const requestPolicies = () => (dispatch) => {
    axios.get(`${URL}/policies`)
        .then(resp => {
            const policies = normalizeData(resp.data, 'id');
            dispatch({ type: RECEIVE_POLICIES, payload: policies })
        })
        .catch((error) => {
            dispatch({type: SET_ERROR,payload:error.response.data});
            setTimeout(() =>{
                dispatch({type: CLEAN_ERROR});
            },timeout)
        })

    dispatch({ type: REQUEST_DATA });
}
const createNewPolicy = (newPolicy) => (dispatch) => {
    axios.post(`${URL}/policies`, newPolicy)
        .then(resp => {
            dispatch({ type: POLICY_CREATED });
        })
        .catch((error) => {
            dispatch({type: SET_ERROR,payload:error.response.data});
            setTimeout(() =>{
                dispatch({type: CLEAN_ERROR});
            },timeout)
        })

    dispatch({ type: REQUEST_DATA })
}
const updatePolicy = (policy) => (dispatch) => {
    axios.put(`${URL}/policies`, policy)
        .then(resp => {
            dispatch({ type: POLICY_CREATED });
        })
        .catch((error) => {
            dispatch({type: SET_ERROR,payload:error.response.data});
            setTimeout(() =>{
                dispatch({type: CLEAN_ERROR});
            },timeout)
        })

    dispatch({ type: REQUEST_DATA })
}
const deletePolicy = (id) => (dispatch) => {
    axios.delete(`${URL}/policies/${id}`)
        .then(resp => {
            requestPolicies()(dispatch);
        })
        .catch((error) => {
            dispatch({type: SET_ERROR,payload:error.response.data});
            setTimeout(() =>{
                dispatch({type: CLEAN_ERROR});
            },timeout)
        })

    dispatch({ type: REQUEST_DATA })
}
const requestRiskType = () => (dispatch) => {

    axios.get(`${URL}/risk`)
        .then(resp => {
            const riskTypes = normalizeData(resp.data, 'id');
            dispatch({ type: RECEIVE_RISK_TYPES, payload: riskTypes })
        })
        .catch((error) => {
            dispatch({type: SET_ERROR,payload:error.response.data});
            setTimeout(() =>{
                dispatch({type: CLEAN_ERROR});
            },timeout)
        })
    dispatch({ type: REQUEST_DATA });
}
const requestcoveragesTypes = () => (dispatch) => {
    axios.get(`${URL}/coverage`)
    .then(resp => {
        const coverageTypes = normalizeData(resp.data, 'id');
        dispatch({ type: RECEIVE_COVERAGE_TYPES, payload: coverageTypes })
    })
    .catch((error) => {
        dispatch({type: SET_ERROR,payload:error.response.data});
        setTimeout(() =>{
            dispatch({type: CLEAN_ERROR});
        },timeout)
    })
    dispatch({ type: REQUEST_DATA });
}
const requestClients = () => (dispatch) => {
    axios.get(`${URL}/client`)
    .then(resp => {
        const clients = normalizeData(resp.data, 'id');
        dispatch({ type: RECEIVE_CLIENTS, payload: clients })
    })
    .catch((error) => {
        dispatch({type: SET_ERROR,payload:error.response.data});
        setTimeout(() =>{
            dispatch({type: CLEAN_ERROR});
        },timeout)
    })
    dispatch({ type: REQUEST_DATA });
}

export const actionCreators = {
    requestPolicies,
    createNewPolicy,
    requestRiskType,
    requestcoveragesTypes,
    updatePolicy,
    deletePolicy,
    requestClients
}

export const INITIAL_STATE = {
    isLoading: false,
    error:null,
    policies: {},
    riskTypes:{},
    clients:{},
    coverageTypes:{}
}

export const reducer = (state = INITIAL_STATE, action) => {
    switch (action.type) {
        case REQUEST_DATA:
            return {
                ...state,
                isLoading: true
            }
        case SET_ERROR:
            return{
                ...state,
                isLoading:false,
                error: action.payload
            };
        case CLEAN_ERROR:
            return{
                ...state,
                error:null
            }
        case RECEIVE_RISK_TYPES:
            return{
                ...state,
                isLoading:false,
                riskTypes: action.payload
            }
        case RECEIVE_COVERAGE_TYPES:
            return{
                ...state,
                isLoading:false,
                coverageTypes: action.payload
            }
        case RECEIVE_POLICIES:
            return {
                ...state,
                isLoading: false,
                policies: action.payload
            }
        case POLICY_CREATED:
            return {
                ...state,
                isLoading: false
            }
        case RECEIVE_CLIENTS:
            return {
                ...state,
                isLoading: false,
                clients: action.payload
            }
        default:
            return state;
    }
}