import { applyMiddleware, combineReducers, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import { reducer as policyState } from './policiesReducer';

const configureStore = (initialState) => {

    const middleware = [
        thunk
    ];

    const rootReducer = combineReducers({
        policyState
    })

    const enhancers = [
        window.__REDUX_DEVTOOLS_EXTENSION__ && window.__REDUX_DEVTOOLS_EXTENSION__()
    ]

    return createStore(
        rootReducer,
        initialState,
        compose(applyMiddleware(...middleware), ...enhancers)
    )
}

export default configureStore;