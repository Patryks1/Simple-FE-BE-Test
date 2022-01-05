import React, { useState, useEffect } from 'react';
import FlatList from 'flatlist-react';

const InfButton = () => {
  
  return (
    <div>
      <FlatList
        list={
          []
          // The data to render
        }
        renderItem={
          () => <h1>Item</h1>
          // this will render your data. It will also return a prop with the current data its rendering.
        }
        renderWhenEmpty={() => <div>List is empty!</div>}
      />

      <button>Show more</button>
    </div>
  );
};

export { InfButton };
