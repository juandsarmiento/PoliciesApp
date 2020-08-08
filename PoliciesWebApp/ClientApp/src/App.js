import React, { Component } from 'react';
import { Route, Switch } from 'react-router';
import { connect } from 'react-redux';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import ApiAuthorizationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { ApplicationPaths } from './components/api-authorization/ApiAuthorizationConstants';
import { HOME_PATH, POLICIES_PATH, CREATE_POLICY_PATH,CLIENT_PATH } from './components/pathConstants';
import Policies from './Entries/Policies'
import CreatePolicy from './Entries/CreatePolicy';
import EditPolicy from './Entries/EditPolicy';
import ManagePolicies from './Entries/ManagePolicies';
import ManagePoliciesClient from './Entries/ManagePoliciesClient';
import ErrorAlertContainer from './Containers/ErrorAlertContainer';
import { actionCreators } from './reducers/policiesReducer'
import { bindActionCreators } from 'redux';
import './App.css'


class App extends Component {
  static displayName = App.name;
  componentDidMount() {
    this.props.actions.requestRiskType();
    this.props.actions.requestPolicies();
    this.props.actions.requestcoveragesTypes();
    this.props.actions.requestClients();
  }
  render() {
    return (
      <>
        <ErrorAlertContainer />
        <Layout>
          <Switch>
            <Route exact path={HOME_PATH} component={Home} />
            <AuthorizeRoute exact path={POLICIES_PATH} component={Policies} />
            <AuthorizeRoute exact path={CREATE_POLICY_PATH} component={CreatePolicy} />
            <AuthorizeRoute exact path={`${POLICIES_PATH}/:id`} component={EditPolicy} />
            <AuthorizeRoute exact path={CLIENT_PATH} component={ManagePolicies} />
            <AuthorizeRoute exact path={`${CLIENT_PATH}/:id`} component={ManagePoliciesClient} />
            <Route path={ApplicationPaths.ApiAuthorizationPrefix} component={ApiAuthorizationRoutes} />
          </Switch>
        </Layout>
      </>
    );
  }
}

const mapDispatch2Props = (dispatch) => ({
  actions: bindActionCreators(actionCreators, dispatch)
})

export default connect((state) => state,mapDispatch2Props)(App);


