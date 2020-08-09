import React from 'react';
import Autocomplete from '@material-ui/lab/Autocomplete';
import TextField from '@material-ui/core/TextField';
import { Col } from 'reactstrap';

const AutocompletePolicies = ({ policies, cols,onClick }) => {
  return (
    <Col cols={cols} className='mb-2'>
      <Autocomplete
        onChange={onClick}
        id="combo-box"
        options={policies}
        getOptionLabel={(option) => option.name}
        renderInput={(params) => 
        <>
          <TextField {...params} label="Combo box" variant="outlined" />
        </>}
      />
    </Col>)
}

export default AutocompletePolicies;