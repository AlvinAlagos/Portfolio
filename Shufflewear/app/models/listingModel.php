<?php
    class listingModel
    {
        public function __construct()
        {
            $this->db = new Model;
        }

        public function getListing($listingId) {
            $this->db->query("SELECT * FROM listing INNER JOIN inventory on listing.itemId = inventory.itemId WHERE listingId = :listingId");
            $this->db->bind(':listingId', $listingId);

            return $this->db->getSingle();
        }

        public function addItem($data){
            $this->db->query("INSERT INTO listing(quantity, price, itemId)  VALUES(:quantity, :price, :itemId)");
            $this->db->bind(':quantity', $data['quantity']);
            $this->db->bind(':price', $data['price']);
            $this->db->bind(':itemId', $data['itemId']);

            if ($this->db->execute()) {
                return true;
            } else {
                return false;
            }
        }

        public function deleteListing($itemId){
            $this->db->query("DELETE FROM listing WHERE itemId=:itemId");
            $this->db->bind(":itemId", $itemId);
            
            if ($this->db->execute()) {
                return true;
            } else {
                return false;
            }
        }

        public function updateQuantity($data){
            $this->db->query("UPDATE listing SET quantity=:quantity WHERE itemId=:itemId");
            $this->db->bind(":itemId", $data['itemId']);
            $this->db->bind(":quantity", $data['updatedQuantity']);
            if ($this->db->execute()) {
                return true;
            } else {
                return false;
            }
        }

        //unused
        public function getItemInfo($itemId){
            $this->db->query("SELECT * FROM inventory i, listing l WHERE l.itemId = :itemId AND i.itemId = :itemId AND l.itemId = i.itemId; ");
            return $this->db->getResultSet();
        }

        public function getAllItems(){
            $this->db->query("SELECT * FROM listing l , inventory i WHERE l.itemId = i.itemId; ");
            return $this->db->getResultSet();
        }

        public function getAllFilteredItems($color){
            $this->db->query("SELECT * FROM inventory i, listing l WHERE l.itemId = i.itemId AND i.color =:color");
            $this->db->bind(':color', $color);
            return $this->db->getResultSet();
        }
        
        public function getQuantity($itemId){
            $this->db->query("SELECT quantity FROM listing WHERE itemId =:itemId");
            $this->db->bind(':itemId', $itemId);
            return $this->db->getSingle();
        }

        // public function getItem($itemId){
        //     $this->db->query("SELECT * FROM listing WHERE itemId =:itemId");
        //     $this->db->bind(':itemId', $itemId);
        //     return $this->db->getSingle();
        // }
    }
