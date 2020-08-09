import React, { useState } from 'react';
import { connect } from 'react-redux';
import FormPolicy from '../components/FormPolicy';
import { actionCreators } from '../reducers/policiesReducer'
import { bindActionCreators } from 'redux';
import Loading from '../components/Loading';
const INITIAL_POLICY = {
    name: '',
    desc:'',
    coverage:0,
    startDate:undefined,
    coverageTime:undefined,
    price:undefined,
    riskId:0,
    policyCoverageTypes:[]
}
const CreatePolicy = ({ isLoading, riskTypes, coverageTypes, actions }) => {
    const [newPolicy, setNewPolicy] = useState(INITIAL_POLICY);
    const handleChange = (e,type) => {
        
        const nextPolicyState = {
            ...newPolicy,
            [e.target.name]: (e.target.type === 'number' || type ==='number' )
                ? parseInt(e.target.value) : e.target.value
        };
        setNewPolicy(nextPolicyState);
    }
    const handleToggle = (e,r) => {
        const newCoverages = [...newPolicy.policyCoverageTypes]
        if(e.target.checked){
            newCoverages.push(r.id);
        }else{
            const index = newCoverages.findIndex(n => n === r.id);
            newCoverages.splice(index,1);
        }
        const newPolictyState = {
            ...newPolicy,
            policyCoverageTypes:newCoverages
        }
        setNewPolicy(newPolictyState);
    }
    const handleSubmit = () => {
        actions.createNewPolicy(newPolicy)
    }
    if (isLoading) return <Loading />;
    return (
        <>
            <h6>Create new policy</h6>
            <FormPolicy 
                policy={newPolicy} 
                riskTypes={riskTypes} 
                coverageTypes={coverageTypes}
                onSubmit={handleSubmit}
                onChange={handleChange}
                toggleCheckBoxes={handleToggle}
            />
        </>
    )
}

const mapState2Props = (state) => {
    const { policyState: { isLoading, riskTypes, coverageTypes } } = state;
    return {
        isLoading,
        riskTypes: Object.values(riskTypes),
        coverageTypes: Object.values(coverageTypes)
    }
}

const mapDispatch2Props = dispatch => ({
    actions: bindActionCreators(actionCreators, dispatch)
})
export default connect(mapState2Props, mapDispatch2Props)(CreatePolicy);