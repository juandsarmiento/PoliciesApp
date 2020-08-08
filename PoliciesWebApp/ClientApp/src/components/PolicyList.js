import React from 'react';
import { ListGroup, ListGroupItem, Button } from 'reactstrap';

const PolicyList = ({ polices,onClick }) => (
    <ListGroup>
        {
            polices.map(p =>
                <ListGroupItem id={p.id}>
                    {p.name}
                    <Button className='float-right' onClick={() => onClick(p)}>
                        Cancel
                    </Button>
                </ListGroupItem>)
        }
    </ListGroup>)
export default PolicyList;